using C__Project.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C__Project.FaresAwad
{
    public partial class InstructorForm : Form
    {
        Form previousForm;
        public InstructorForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            List<Course> courses = GetInstructorCourses();

            dataGridView.DataSource = courses;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddQuestionForm addCourseForm = new AddQuestionForm();
            addCourseForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditQuestionForm editCourseForm = new EditQuestionForm();
            editCourseForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteQuestionForm deleteCourseForm = new DeleteQuestionForm();
            deleteCourseForm.ShowDialog();
        }

        private List<Course> GetInstructorCourses()
        {
            int instructorId = UserSession.Id;

            using (var dbContext = new ExamSystemContext())
            {
                var courses = dbContext.TeachesAts
                    .Where(ta => ta.InstructorId == instructorId)
                    .Select(ta => ta.Course)
                    .ToList();

                return courses;
            }
        }

        private void btnAddEx_Click(object sender, EventArgs e)
        {
            AddQuestionToExamForm addQuestionToExamForm = new AddQuestionToExamForm();
            addQuestionToExamForm.ShowDialog();
        }

        private void InstructorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }
    }
}