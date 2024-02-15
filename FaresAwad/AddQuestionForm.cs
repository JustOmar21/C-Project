using C__Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project.FaresAwad
{
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
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

                if (!IsInstructorAllowedToAddQuestion(instructorId, courseId))
                {
                    MessageBox.Show("You are not allowed to add a question to this course.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string body = txtBody.Text;
                string type = txtType.Text;

                int correctChoiceNumber;
                if (!int.TryParse(txtCorrectChoiceNumber.Text, out correctChoiceNumber))
                {
                    MessageBox.Show("Please enter a valid correct choice number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if the question is a duplicate
                if (IsDuplicateQuestion(courseId, body))
                {
                    MessageBox.Show("This question already exists for the selected course.", "Duplicate Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Continue with the rest of the logic to create and save the question...

                // Create a new question
                Question newQuestion = new Question
                {
                    Body = body,
                    Type = type,
                    CorrectChoiceNumber = correctChoiceNumber,
                    CourseId = courseId,
                    InstructorId = instructorId
                };

                // Create choices for the question
                List<QuestionChoices> choices = new List<QuestionChoices>
                {
                    new QuestionChoices { ChoiceNumber = 1, Choice = txtChoiceNumber1.Text },
                    new QuestionChoices { ChoiceNumber = 2, Choice = txtChoiceNumber2.Text },
                    new QuestionChoices { ChoiceNumber = 3, Choice = txtChoiceNumber3.Text },
                    new QuestionChoices { ChoiceNumber = 4, Choice = txtChoiceNumber4.Text },
                };

                newQuestion.Choices = choices;

                // Add the new question to the database context and save changes
                using (var dbContext = new ExamSystemContext())
                {
                    dbContext.Questions.Add(newQuestion);
                    dbContext.SaveChanges();
                }

                MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsInstructorAllowedToAddQuestion(int instructorId, int courseId)
        {
            using (var dbContext = new ExamSystemContext())
            {
                return dbContext.TeachesAts.Any(ta => ta.InstructorId == instructorId && ta.CourseId == courseId);
            }
        }

        private bool IsDuplicateQuestion(int courseId, string body)
        {
            using (var dbContext = new ExamSystemContext())
            {
                return dbContext.Questions.Any(q => q.CourseId == courseId && q.Body == body);
            }
        }
    }
}
