using C__Project.Models;
using Microsoft.EntityFrameworkCore;
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

namespace C__Project.OmarTarek
{
    public partial class Classes : Form
    {
        Form previousForm;
        ExamSystemContext Context;
        Regex nameRegex = new Regex(@"^(?=.{3,50}$)[a-zA-Z0-9]+(?:[' -][a-zA-Z0-9]+)*$");
        public Classes(Form previousForm)
        {

            InitializeComponent();
            this.previousForm = previousForm;
            Context = new ExamSystemContext();
            GetData();
            addBTN.Enabled = false;
            floorNum.Minimum = 1;
            floorNum.Value = floorNum.Minimum;
            floorNum.Maximum = 10;
            floorNum.ReadOnly = true;

        }

        public void GetData()
        {
            var branches = Context.Branches.Select(b => new { Name = b.Name, ID = b.Id }).OrderBy(b => b.Name).ToList();
            dataGridView1.DataSource = Context.Classes
                .Include(Class => Class.Branch)
                .Where(Class => Class.Name.Contains(SearchTXT.Text.Trim()))
                .Select(Class => new { Class.Id, Class.Name, Class.Floor, Branch = Class.Branch.Name, BranchID = Class.BranchId })
                .OrderBy(dept => dept.Branch)
                .ToList();
            branchCB.DataSource = branches;
            branchCB.DisplayMember = "Name";
            branchCB.SelectedIndex = 0;
            branchCB.ValueMember = "ID";
            branchCB.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["BranchID"].Visible = false;
            dataGridView1.TopLeftHeaderCell.Value = "Edit";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();

        }

        private void Department_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }

        public void RegexTest()
        {
            bool nameVali = nameRegex.IsMatch(nameTXT.Text.Trim());

            if (nameVali)
            { addBTN.Enabled = true; updateBTN.Enabled = true; }
            else
            { addBTN.Enabled = false; updateBTN.Enabled = false; }

        }

        private void nameTXT_TextChanged(object sender, EventArgs e)
        {
            bool nameVali = nameRegex.IsMatch(nameTXT.Text.Trim());
            if (nameVali) { nameValiLBL.Visible = false; } else { nameValiLBL.Visible = true; }
            RegexTest();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            Class newClass = new Class() { Name = nameTXT.Text.Trim(), Floor = (int)floorNum.Value, BranchId = (int)branchCB.SelectedValue };
            Context.Classes.Add(newClass);
            Context.SaveChanges();
            EndModification();
            GetData();

        }
        private void EndModification()
        {
            nameTXT.Text = idTXT.Text = "";
            floorNum.Value = 1;
            nameValiLBL.Visible = false;
            branchCB.SelectedIndex = 0;
            addBTN.Visible = true;
            updateBTN.Visible = false;
            deleteBTN.Visible = false;
            exitModiBTN.Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                idTXT.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                nameTXT.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                floorNum.Value = (int)dataGridView1[2, e.RowIndex].Value;
                branchCB.SelectedValue = dataGridView1[4, e.RowIndex].Value;

                addBTN.Visible = false;
                updateBTN.Visible = true;
                deleteBTN.Visible = true;
                exitModiBTN.Visible = true;
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            Class singleClass = Context.Classes.Where(Class => Class.Id == int.Parse(idTXT.Text)).SingleOrDefault();
            singleClass.Name = nameTXT.Text.Trim();
            singleClass.Floor = (int)floorNum.Value;
            singleClass.BranchId = (int)branchCB.SelectedValue;
            Context.SaveChanges();
            EndModification();
            GetData();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Class singleClass = Context.Classes
                    .Where(Class => Class.Id == int.Parse(idTXT.Text))
                    .Include(Class => Class.TeachesClass)
                    .Include(Class => Class.Students)
                    .SingleOrDefault();

                if (singleClass.TeachesClass.Count > 0)
                    throw new Exception($"You cannot Delete this class since it contains {singleClass.TeachesClass.Count} {(singleClass.TeachesClass.Count == 1 ? "Course" : "Courses")} being teached there");
                if (singleClass.Students.Count > 0)
                    throw new Exception($"You cannot delete this class since it contains {singleClass.Students.Count} {(singleClass.Students.Count == 1 ? "Student" : "Students")}");

                Context.Classes.Remove(singleClass);
                Context.SaveChanges();
            }
            catch(Exception ex)
            {
                if(ex.InnerException != null)
                {
                    MessageBox.Show($"{ex.InnerException}" ,"Error" ,MessageBoxButtons.OK , MessageBoxIcon.Error);
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

        private void exitModiBTN_Click(object sender, EventArgs e)
        {
            EndModification();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
