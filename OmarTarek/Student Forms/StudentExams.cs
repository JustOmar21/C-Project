using C__Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project.OmarTarek.Student_Forms
{
    public partial class StudentExams : Form
    {
        ExamSystemContext Context = new ExamSystemContext();
        int StudentID = 1;  // replace this with a static variable of CurrentUserID
        Form previousForm;
        public StudentExams(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            GetData();

        }
        public void GetData()
        {
            var studentExam = Context.StudentExams
                .Where(student => student.StudentId == StudentID)
                .Include(exam => exam.Exam)
                .ThenInclude(exam => exam.Course)
                .Where(exam => exam.Exam.Name.Contains(SearchTXT.Text.Trim()))
                .Select(exam => new
                {
                    exam.Id,
                    exam.Exam.Name,
                    Status = DateTime.Now < exam.Exam.EndTime ? "Pending" : (exam.Degree < exam.Exam.Course.MinDegree ? "Failed" : "Passed"), 
                    exam.Exam.StartTime.Date,
                    StartTime = exam.Exam.StartTime.ToShortTimeString(),
                    EndTime = exam.Exam.EndTime.ToShortTimeString(),
                    Course = exam.Exam.Course.Name,
                    Degree = DateTime.Now < exam.Exam.EndTime ? "After Exam is done" : exam.Degree.ToString()
                })
                .OrderByDescending(exam => exam.Date)
                .ToList();

            dataGridView1.DataSource = studentExam;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.TopLeftHeaderCell.Value = "Select";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();

        }
        public void StudentExams_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                string ExamDate = dataGridView1[3, e.RowIndex].Value.ToString().Split(" ").First();
                string ExamStart = dataGridView1[4, e.RowIndex].Value.ToString();
                string ExamEnd = dataGridView1[5, e.RowIndex].Value.ToString();
                idLBL.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                examName.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                date.Text = ExamDate;
                startTime.Text = ExamStart;
                endTime.Text = ExamEnd;
                courseTXT.Text = dataGridView1[6,e.RowIndex].Value.ToString();

                DateTime dateTime = DateTime.Parse(dataGridView1[3, e.RowIndex].Value.ToString());
                DateTime start = DateTime.Parse($"{ExamDate} {ExamStart}");
                DateTime end = DateTime.Parse($"{ExamDate} {ExamEnd}");

                if (DateTime.Now < end && DateTime.Now >= start)
                {
                    enterBTN.Enabled = true;
                }
                else if (DateTime.Now < start)
                {
                    MessageBox.Show($"The date now is \n{DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}\nYou cannot access this exam until \n{start.ToLongDateString()} {start.ToShortTimeString()}");
                    enterBTN.Enabled = false;
                }
                else if (DateTime.Now >= end)
                {
                    MessageBox.Show($"The date now is \n{DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}\nThe Exam was Finished at \n{end.ToLongDateString()} {end.ToShortTimeString()}");
                    enterBTN.Enabled = false;
                }
            }
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void enterBTN_Click(object sender, EventArgs e)
        {
            StudentExam student = Context.StudentExams
                .Where(student => student.Id == int.Parse(idLBL.Text))
                .Include(student => student.Exam)
                .SingleOrDefault();
            string exam = $"{examName.Text} - {courseTXT.Text}";
            StudentAnswering studentAnswer = new StudentAnswering(this, student , exam);
            this.Hide();
            studentAnswer.Show();
        }
    }

}
