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

        public Courses(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            Context = new ExamSystemContext();
            addBTN.Enabled = false;
            GetData();
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
                    course.MinDegree,
                    
                })
                .OrderBy(track => track.Name) //ask omar
                .ToList();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.TopLeftHeaderCell.Value = "Edit";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AutoResizeColumns();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course() 
                { 
                    Name = nameTXT.Text.Trim(),
                    Description = descritionTXT.Text.Trim()
                };
                Context.Add(c);
                Context.SaveChanges();
                EndModification();
                GetData();
                /*Course c = new Course()
                {
                    Name = nameTXT.Text.Trim(),
                    Description = ,
                    MaxDegree = ,
                    MinDegree =

                };*/
                /*                Context.Courses.Add(c);
                */
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            finally
            {
                EndModification();
                GetData();
            }

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {

        }

        private void updateBTN_Click(object sender, EventArgs e)
        {

        }

        private void exitModiBTN_Click(object sender, EventArgs e)
        {
            EndModification();

        }

        private void nameTXT_TextChanged(object sender, EventArgs e)
        {
            bool nameVali = nameRegex.IsMatch(nameTXT.Text.Trim());
            if (nameVali) { nameValiLBL.Visible = false; } else { nameValiLBL.Visible = true; }
            RegexTest();

        }
        private void EndModification()
        {
            nameValiLBL.Visible = false;
            nameTXT.Text = descritionTXT.Text = "";
            nameValiLBL.Visible = descriptionValiLBL.Visible = false;
            addBTN.Visible = true;
            updateBTN.Visible = false;
            deleteBTN.Visible = false;
            exitModiBTN.Visible = false;

        }
        public void RegexTest()
        {
            bool nameVali = nameRegex.IsMatch(nameTXT.Text.Trim());
            bool descriptionVali = descritionRegex.IsMatch(descritionTXT.Text.Trim());

            if (nameVali && descriptionVali)
            { addBTN.Enabled = true; updateBTN.Enabled = true; }
            else
            { addBTN.Enabled = false; updateBTN.Enabled = false; }

        }

        private void nameValiLBL_Click(object sender, EventArgs e)
        {

        }

        private void descritionTXT_TextChanged(object sender, EventArgs e)
        {
            bool descriptionVali = descritionRegex.IsMatch(descritionTXT.Text.Trim());
            if (descriptionVali) { descriptionValiLBL.Visible = false; } else { descriptionValiLBL.Visible = true; }
            RegexTest();
        }
    }
}
