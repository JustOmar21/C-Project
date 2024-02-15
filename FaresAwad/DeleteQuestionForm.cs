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
    public partial class DeleteQuestionForm : Form
    {
        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                int questionIdToRemove;
                if (!int.TryParse(txtQuestionIdToRemove.Text, out questionIdToRemove))
                {
                    MessageBox.Show("Please enter a valid question ID to remove.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int instructorId = UserSession.Id;

                if (!IsInstructorAllowedToRemoveQuestion(instructorId, questionIdToRemove))
                {
                    MessageBox.Show("You are not allowed to remove this question.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var dbContext = new ExamSystemContext())
                {
                    var questionToRemove = dbContext.Questions.Find(questionIdToRemove);

                    if (questionToRemove != null)
                    {
                        // Remove the question from the database
                        dbContext.Questions.Remove(questionToRemove);
                        dbContext.SaveChanges();

                        MessageBox.Show("Question removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool IsInstructorAllowedToRemoveQuestion(int instructorId, int questionIdToRemove)
        {
            using (var dbContext = new ExamSystemContext())
            {
                // Check if the instructor is allowed to remove the question
                return dbContext.Questions.Any(q => q.Id == questionIdToRemove && q.InstructorId == instructorId);
            }
        }
    }
}
