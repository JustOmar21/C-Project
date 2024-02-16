using System;
using System.Linq;
using System.Windows.Forms;
using C__Project.Models;

namespace C__Project.FaresAwad
{
    public partial class AddQuestionToExamForm : Form
    {
        public AddQuestionToExamForm()
        {
            InitializeComponent();
        }

        private void btnShowQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                int courseId;
                if (!int.TryParse(txtCourseIdToSearch.Text, out courseId))
                {
                    MessageBox.Show("Please enter a valid course ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int instructorId = UserSession.Id;

                // Check if the instructor is allowed to view questions for the specified course
                if (!IsInstructorAllowedToViewQuestions(instructorId, courseId))
                {
                    MessageBox.Show("You are not allowed to view questions for this course.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var dbContext = new ExamSystemContext())
                {
                    // Retrieve questions related to the specified course and instructor
                    var questions = dbContext.Questions
                        .Where(q => q.CourseId == courseId && q.InstructorId == instructorId)
                        .ToList();

                    // Check if dataGridView1 is not null before setting its DataSource
                    if (dataGridView1 != null)
                    {
                        dataGridView1.DataSource = questions;
                    }
                    else
                    {
                        MessageBox.Show("Error: dataGridView1 is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsInstructorAllowedToViewQuestions(int instructorId, int courseId)
        {
            using (var dbContext = new ExamSystemContext())
            {
                return dbContext.TeachesAts.Any(ta => ta.InstructorId == instructorId && ta.CourseId == courseId);
            }
        }

        private void btnAddQuestionToExam_Click(object sender, EventArgs e)
        {
            try
            {
                int courseIdToAdd, examIdToAdd, questionIdToAdd, questionDegreeToAdd;

                if (!int.TryParse(txtCourseIdToAdd.Text, out courseIdToAdd) ||
                    !int.TryParse(txtExamIdToAdd.Text, out examIdToAdd) ||
                    !int.TryParse(txtQuestionIdToAdd.Text, out questionIdToAdd) ||
                    !int.TryParse(txtQuestionDegreeToAdd.Text, out questionDegreeToAdd))
                {
                    MessageBox.Show("Please enter valid numeric values for Course ID, Exam ID, Question ID, and Question Degree.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int instructorId = UserSession.Id;

                // Check if the instructor is allowed to add questions to the specified course
                if (!IsInstructorAllowedToAddQuestions(instructorId, courseIdToAdd))
                {
                    MessageBox.Show("You are not allowed to add questions to this course.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var dbContext = new ExamSystemContext())
                {
                    // Check if the question is already added to the exam
                    if (IsQuestionAlreadyAddedToExam(dbContext, questionIdToAdd, examIdToAdd))
                    {
                        MessageBox.Show("This question is already added to the exam.", "Duplicate Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check if the instructor exceeds the limit of 10 questions for the exam
                    if (GetExamQuestionsCount(dbContext, examIdToAdd) >= 10)
                    {
                        MessageBox.Show("You can only add up to 10 questions to the exam.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Create a new ExamQuestion
                    var examQuestion = new ExamQuestion
                    {
                        QuestionId = questionIdToAdd,
                        ExamId = examIdToAdd,
                        Degree = questionDegreeToAdd
                    };

                    // Add the new ExamQuestion to the database
                    dbContext.ExamQuestions.Add(examQuestion);
                    dbContext.SaveChanges();

                    MessageBox.Show("Question added to the exam successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsInstructorAllowedToAddQuestions(int instructorId, int courseId)
        {
            using (var dbContext = new ExamSystemContext())
            {
                return dbContext.TeachesAts.Any(ta => ta.InstructorId == instructorId && ta.CourseId == courseId);
            }
        }

        private bool IsQuestionAlreadyAddedToExam(ExamSystemContext dbContext, int questionId, int examId)
        {
            return dbContext.ExamQuestions.Any(eq => eq.QuestionId == questionId && eq.ExamId == examId);
        }

        private int GetExamQuestionsCount(ExamSystemContext dbContext, int examId)
        {
            return dbContext.ExamQuestions.Count(eq => eq.ExamId == examId);
        }
    }
}
