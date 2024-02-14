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

namespace C__Project.Khateep
{
    public partial class Courses : Form
    {
        Form previousForm;
        ExamSystemContext Context;
        Regex descritionRegex = new Regex(@"^(?=.{3,50}$)[a-zA-Z0-9]+(?:[' -][a-zA-Z0-9]+)*$");
        Regex nameRegex = new Regex(@"^(?=.{3,50}$)[a-zA-Z0-9]+(?:[' -][a-zA-Z0-9]+)*$");
        /*Regex maxDegreeRegex = new Regex(@"^(?=.{3,50}$)[a-zA-Z0-9]+(?:[' -][a-zA-Z0-9]+)*$");
        Regex minDegreeRegex = new Regex(@"^(?=.{3,50}$)[a-zA-Z0-9]+(?:[' -][a-zA-Z0-9]+)*$");
*/


        public Courses(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            Context = new ExamSystemContext();
            GetData();

            addBTN.Enabled = true;
            maxDegreeNum.Minimum = 1;
            maxDegreeNum.Maximum = 100;
            maxDegreeNum.Value = 100;
            maxDegreeNum.ReadOnly = true;
            minDegreeNum.Minimum = 0;
            minDegreeNum.Maximum = 99;
            minDegreeNum.Value = 1;
            minDegreeNum.ReadOnly = true;


        }
        public void GetData()
        {
            dataGridView1.DataSource =
                Context.Courses
                .Where(course => course.Name.Contains(SearchTXT.Text.Trim()))
                .Select(course => new
                {
                    course.Id,
                    course.Name,
                    course.Description,
                    course.MaxDegree,
                    course.MinDegree

                })
                .OrderBy(course => course.Name) 
                .ToList();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.TopLeftHeaderCell.Value = "Edit";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AutoResizeColumns();
        }
        private void addBTN_Click(object sender, EventArgs e)
        {
            Course newCourse = new Course() { Name = nameTXT.Text.Trim(), Description = descritionTXT.Text.Trim(), MaxDegree = (int)maxDegreeNum.Value, MinDegree = (int)minDegreeNum.Value };
            Context.Courses.Add(newCourse);
            Context.SaveChanges();
            EndModification();

            GetData();
        }
        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idTXT.Text, out int courseId))
            {
                Course singleCourse = Context.Courses.SingleOrDefault(course => course.Id == courseId);

                if (singleCourse != null)
                {
                    Context.Courses.Remove(singleCourse);
                    Context.SaveChanges();
                    EndModification();
                    GetData();
                }
                else
                {
                    MessageBox.Show("Course not found. Please enter a valid Course Id.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Course Id. Please enter a valid integer.");
            }
        }
        private void updateBTN_Click(object sender, EventArgs e)
        {
            Course singleCourse = Context.Courses.Where(Course => Course.Id == int.Parse(idTXT.Text)).SingleOrDefault();
            singleCourse.Name = nameTXT.Text.Trim();
            singleCourse.MaxDegree = (int)maxDegreeNum.Value;
            singleCourse.MinDegree = (int)minDegreeNum.Value;
            Context.SaveChanges();
            EndModification();
            GetData();
        }
        private void exitModiBTN_Click(object sender, EventArgs e)
        {
            EndModification();

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                idTXT.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                nameTXT.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                descritionTXT.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                maxDegreeNum.Value = (int)dataGridView1[3, e.RowIndex].Value;
                minDegreeNum.Value = (int)dataGridView1[4, e.RowIndex].Value;

                addBTN.Visible = false;
                updateBTN.Visible = true;
                deleteBTN.Visible = true;
                exitModiBTN.Visible = true;
            }

        }
        private void nameTXT_TextChanged(object sender, EventArgs e)
        {
            bool nameVali = nameRegex.IsMatch(nameTXT.Text.Trim());
            if (nameVali) { nameValiLBL.Visible = false; } else { nameValiLBL.Visible = true; }
            /*            RegexTest();
            */
        }
        
        
        private void descritionTXT_TextChanged(object sender, EventArgs e)
        {
            bool descriptionVali = descritionRegex.IsMatch(descritionTXT.Text.Trim());
            if (descriptionVali) { descriptionValiLBL.Visible = false; }
            else { descriptionValiLBL.Visible = true; }
            /*            RegexTest();
            */
        }
        private void EndModification()
        {
            nameTXT.Text = descritionTXT.Text = idTXT.Text = "";
            nameValiLBL.Visible = descriptionValiLBL.Visible = false;
            addBTN.Visible = true;
            updateBTN.Visible = false;
            deleteBTN.Visible = false;
            exitModiBTN.Visible = false;
            maxDegreeNum.Value = 1;
            minDegreeNum.Value = 0;
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
        
        private void Courses_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }
        private void Courses_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        /* public void RegexTest()
         {
             bool nameVali = nameRegex.IsMatch(nameTXT.Text.Trim());
             bool descriptionVali = descritionRegex.IsMatch(descritionTXT.Text.Trim());
             *//*bool maxDegreeVali = maxDegreeRegex.IsMatch(maxDegreeTXT.Text.Trim());
             bool minDegreeVali = minDegreeRegex.IsMatch(minDegreeTXT.Text.Trim());*//*


             if (nameVali && descriptionVali*//* && maxDegreeVali && minDegreeVali*//*)
             { addBTN.Enabled = true; updateBTN.Enabled = true; }
             else
             { addBTN.Enabled = false; updateBTN.Enabled = false; }

         }*/
    }
}
