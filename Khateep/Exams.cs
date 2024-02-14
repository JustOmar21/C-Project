using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using C__Project.Models;
using Microsoft.EntityFrameworkCore;

namespace C__Project.Khateep
{
    public partial class Exams : Form
    {
        Form previousForm;
        ExamSystemContext Context;
        Regex examRegex = new Regex(@"^(?=.{3,50}$)[a-zA-Z0-9]+(?:[' -][a-zA-Z0-9]+)*$");
        public Exams(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            Context = new ExamSystemContext();
            GetData();
            addBTN.Enabled = false;
            startTimeDP.Value = new DateTime(startTimeDP.Value.Year, startTimeDP.Value.Month, startTimeDP.Value.Day, startTimeDP.Value.Hour, startTimeDP.Value.Minute, 0, 0);
            endTimeDP.Value = endTimeDP.Value.AddHours(1);
            endTimeDP.Value = new DateTime(endTimeDP.Value.Year, endTimeDP.Value.Month, endTimeDP.Value.Day, endTimeDP.Value.Hour, endTimeDP.Value.Minute, 0, 0);
        }
        public void GetData()
        {
            var courses = Context.Courses.Select(b => new { Name = b.Name, ID = b.Id }).OrderBy(b => b.Name).ToList();
            dataGridView1.DataSource =
                Context.Exams.Include(exam => exam.Course)
/*                .ThenInclude(dept => dept.Branch)
*/                .Where(exam => exam.Name.Contains(SearchTXT.Text.Trim()))
                .Select(exam => new
                {
                    exam.Id,
                    CourseID = exam.CourseId,
                    exam.Name,
                    Course = exam.Course.Name,
                    exam.StartTime,
                    exam.EndTime
                    /*                    Branch = track.Department.Branch.Name,
                    *//*                    exam.Description
                    */
                })
                .OrderBy(exam => exam.Name)
                .ThenBy(exam => exam.Course)
                .ToList();
            corsCB.DataSource = courses;
            corsCB.DisplayMember = "Name";
            corsCB.SelectedIndex = 0;
            corsCB.ValueMember = "ID";
            corsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["CourseID"].Visible = false;
            dataGridView1.TopLeftHeaderCell.Value = "Edit";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }
        public void RegexTest()
        {
            bool nameVali = examRegex.IsMatch(nameTXT.Text.Trim());

            if (nameVali)
            { addBTN.Enabled = true; updateBTN.Enabled = true; }
            else
            { addBTN.Enabled = false; updateBTN.Enabled = false; }

        }

        private void Exams_Load(object sender, EventArgs e)
        {

        }
        private void Exams_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void nameTXT_TextChanged(object sender, EventArgs e)
        {
            bool nameVali = examRegex.IsMatch(nameTXT.Text.Trim());
            if (nameVali) { nameValiLBL.Visible = false; } else { nameValiLBL.Visible = true; }
            RegexTest();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {

                Exam exam = new Exam()
                {
                    Name = nameTXT.Text.Trim(),
                    CourseId = (int)corsCB.SelectedValue,
                    StartTime = startTimeDP.Value,
                    EndTime = endTimeDP.Value

                };

                if (exam.EndTime <= exam.StartTime) throw new Exception("Exam Start Time must be earlier than End Time");
                if (exam.EndTime - exam.StartTime < new TimeSpan(1, 0, 0)) throw new Exception("Exam time must be more than one hour");
                if (exam.EndTime - exam.StartTime >= new TimeSpan(4, 0, 0)) throw new Exception("Exam time must be less than four hours");
                if (exam.EndTime.Date != exam.StartTime.Date) throw new Exception("Exam must be on the same day");

                Context.Exams.Add(exam);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"{ex.InnerException}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                EndModification();
                GetData();
            }
        }
        private void EndModification()
        {
            nameTXT.Text = idTXT.Text = "";
            nameValiLBL.Visible = false;
            startTimeDP.Value = DateTime.Now;
            endTimeDP.Value = DateTime.Now;
            startTimeDP.Value = new DateTime(startTimeDP.Value.Year, startTimeDP.Value.Month, startTimeDP.Value.Day, startTimeDP.Value.Hour, startTimeDP.Value.Minute, 0, 0);
            endTimeDP.Value = endTimeDP.Value.AddHours(1);
            endTimeDP.Value = new DateTime(endTimeDP.Value.Year, endTimeDP.Value.Month, endTimeDP.Value.Day, endTimeDP.Value.Hour, endTimeDP.Value.Minute, 0, 0);
            corsCB.SelectedIndex = 0;
            addBTN.Visible = true;
            updateBTN.Visible = false;
            deleteBTN.Visible = false;
            exitModiBTN.Visible = false;


        }

        private void nameLBL_Click(object sender, EventArgs e)
        {

        }

        private void idTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Exam exam = Context.Exams
                .Where(exam => exam.Id == int.Parse(idTXT.Text))
                .Include(exam => exam.Students)
                .SingleOrDefault();

                if (exam.Students.Count > 0) throw new Exception($"You cannot delete this Exam since it contains {exam.Students.Count} {(exam.Students.Count == 1 ? "Student" : "Students")}");

                Context.Exams.Remove(exam);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"{ex.InnerException}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                EndModification();
                GetData();
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            Exam exam = Context.Exams
                .Where(exam => exam.Id == int.Parse(idTXT.Text))
            .SingleOrDefault();

            exam.Name = nameTXT.Text.Trim();
            exam.CourseId = (int)corsCB.SelectedValue;
            exam.StartTime = startTimeDP.Value;
            exam.EndTime = endTimeDP.Value;
            if (exam.EndTime <= exam.StartTime) throw new Exception("Exam Start Time must be earlier than End Time");
            if (exam.EndTime - exam.StartTime < new TimeSpan(1, 0, 0)) throw new Exception("Exam time must be more than one hour");
            if (exam.EndTime - exam.StartTime >= new TimeSpan(4, 0, 0)) throw new Exception("Exam time must be less than four hours");
            if (exam.EndTime.Date != exam.StartTime.Date) throw new Exception("Exam must be on the same day");
            Context.SaveChanges();
            EndModification();
            GetData();
        }

        private void exitModiBTN_Click(object sender, EventArgs e)
        {
            EndModification();
        }

        private void startTimeDP_ValueChanged(object sender, EventArgs e)
        {
            startTimeDP.Value = new DateTime(startTimeDP.Value.Year, startTimeDP.Value.Month, startTimeDP.Value.Day, startTimeDP.Value.Hour, startTimeDP.Value.Minute, 0, 0);
        }

        private void endTimeDP_ValueChanged(object sender, EventArgs e)
        {
            endTimeDP.Value = new DateTime(endTimeDP.Value.Year, endTimeDP.Value.Month, endTimeDP.Value.Day, endTimeDP.Value.Hour, endTimeDP.Value.Minute, 0, 0);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                idTXT.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                corsCB.SelectedValue = (int)dataGridView1[1, e.RowIndex].Value;
                nameTXT.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                startTimeDP.Value = (DateTime)dataGridView1[4, e.RowIndex].Value;
                endTimeDP.Value = (DateTime)dataGridView1[5, e.RowIndex].Value;

                addBTN.Visible = false;
                updateBTN.Visible = true;
                deleteBTN.Visible = true;
                exitModiBTN.Visible = true;
            }
        }
    }
}
