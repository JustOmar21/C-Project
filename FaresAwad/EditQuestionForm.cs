using C__Project.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C__Project.FaresAwad
{
    public partial class EditQuestionForm : Form
    {
        public EditQuestionForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId;
                if (!int.TryParse(txtCourseId.Text, out courseId))
                {
                    MessageBox.Show("Please enter a valid course ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int instructorId = UserSession.Id;

                if (!IsInstructorAllowedToUpdateQuestion(instructorId, courseId))
                {
                    MessageBox.Show("You are not allowed to update a question in this course.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string body = txtBody.Text;
                string type = txtType.Text;

                int questionIdToUpdate;
                if (!int.TryParse(txtQuestionIdToUpdate.Text, out questionIdToUpdate))
                {
                    MessageBox.Show("Please enter a valid question ID to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int correctChoiceNumber;
                if (!int.TryParse(txtCorrectChoiceNumber.Text, out correctChoiceNumber))
                {
                    MessageBox.Show("Please enter a valid correct choice number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if the question is a duplicate after the update
                if (IsDuplicateQuestion(courseId, body, questionIdToUpdate))
                {
                    MessageBox.Show("This question already exists for the selected course.", "Duplicate Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var dbContext = new ExamSystemContext())
                {
                    // Retrieve the existing question from the database
                    var existingQuestion = dbContext.Questions.Find(questionIdToUpdate);

                    if (existingQuestion != null)
                    {
                        // Update the existing question properties
                        existingQuestion.Body = body;
                        existingQuestion.Type = type;
                        existingQuestion.CorrectChoiceNumber = correctChoiceNumber;
                        existingQuestion.CourseId = courseId;

                        // Update the choices if the question type is MCQ
                        if (type == "MCQ")
                        {
                            UpdateMultipleChoiceQuestion(dbContext, existingQuestion);
                        }
                        else
                        {
                            // Update the choices for the other question types
                            existingQuestion.Choices = new List<QuestionChoices>
                            {
                                new QuestionChoices { ChoiceNumber = 1, Choice = txtChoiceNumber1.Text },
                                new QuestionChoices { ChoiceNumber = 2, Choice = txtChoiceNumber2.Text },
                                new QuestionChoices { ChoiceNumber = 3, Choice = txtChoiceNumber3.Text },
                                new QuestionChoices { ChoiceNumber = 4, Choice = txtChoiceNumber4.Text },
                            };
                        }

                        // Save changes to the database
                        dbContext.SaveChanges();

                        MessageBox.Show("Question updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Question not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsInstructorAllowedToUpdateQuestion(int instructorId, int courseId)
        {
            using (var dbContext = new ExamSystemContext())
            {
                return dbContext.TeachesAts.Any(ta => ta.InstructorId == instructorId && ta.CourseId == courseId);
            }
        }

        private bool IsDuplicateQuestion(int courseId, string body, int questionIdToExclude)
        {
            using (var dbContext = new ExamSystemContext())
            {
                return dbContext.Questions.Any(q => q.CourseId == courseId && q.Body == body && q.Id != questionIdToExclude);
            }
        }

        private void UpdateMultipleChoiceQuestion(ExamSystemContext dbContext, Question question)
        {
            // Update the choices for the existing question
            var choices = dbContext.QuestionChoices.Where(qc => qc.QuestionId == question.Id).ToList();

            choices[0].Choice = txtChoiceNumber1.Text;
            choices[1].Choice = txtChoiceNumber2.Text;
            choices[2].Choice = txtChoiceNumber3.Text;
            choices[3].Choice = txtChoiceNumber4.Text;

            // Save changes to the database
            dbContext.SaveChanges();
        }
    }
}
