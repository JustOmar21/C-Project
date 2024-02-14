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

namespace C__Project.OmarTarek
{
    public partial class Branches : Form
    {
        Form previousForm;
        ExamSystemContext Context;
        Regex BranchRegex = new Regex(@"^(?=.{3,50}$)[a-zA-Z0-9]+(?:[' -][a-zA-Z0-9]+)*$");
        public Branches(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            Context = new ExamSystemContext();
            GetData();
            addBTN.Enabled = false;

        }

        public void GetData()
        {
            dataGridView1.DataSource = Context.Branches.Where(B => B.Name.Contains(SearchTXT.Text.Trim())).Select(B => new { B.Id, B.Name, B.Location }).ToList();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.TopLeftHeaderCell.Value = "Edit";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();
        }

        public void RegexTest()
        {
            bool nameVali = BranchRegex.IsMatch(nameTXT.Text.Trim());
            bool locVali = BranchRegex.IsMatch(locationTXT.Text.Trim());

            if (locVali && nameVali)
            { addBTN.Enabled = true; updateBTN.Enabled = true; }
            else
            { addBTN.Enabled = false; updateBTN.Enabled = false; }

        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            Branch b = new Branch() { Name = nameTXT.Text.Trim(), Location = locationTXT.Text.Trim() };
            Context.Branches.Add(b);
            Context.SaveChanges();
            GetData();
            nameTXT.Text = locationTXT.Text = "";
            nameValiLBL.Visible = locationValiLBL.Visible = false;
        }

        private void Branches_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }

        private void nameTXT_TextChanged(object sender, EventArgs e)
        {
            bool nameVali = BranchRegex.IsMatch(nameTXT.Text.Trim());
            if (nameVali) { nameValiLBL.Visible = false; } else { nameValiLBL.Visible = true; }
            RegexTest();
        }

        private void locationTXT_TextChanged(object sender, EventArgs e)
        {
            bool locVali = BranchRegex.IsMatch(locationTXT.Text.Trim());
            if (locVali) { locationValiLBL.Visible = false; } else { locationValiLBL.Visible = true; }
            RegexTest();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                idTXT.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                nameTXT.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                locationTXT.Text = dataGridView1[2, e.RowIndex].Value.ToString();

                addBTN.Visible = false;
                updateBTN.Visible = true;
                deleteBTN.Visible = true;
                exitModiBTN.Visible = true;
            }

        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            Branch b = Context.Branches.Where(b => b.Id == int.Parse(idTXT.Text)).SingleOrDefault();
            b.Name = nameTXT.Text.Trim(); b.Location = locationTXT.Text.Trim();
            Context.SaveChanges();
            GetData();
            EndModification();
        }

        private void EndModification()
        {
            nameTXT.Text = locationTXT.Text = idTXT.Text = "";
            nameValiLBL.Visible = locationValiLBL.Visible = false;
            addBTN.Visible = true;
            updateBTN.Visible = false;
            deleteBTN.Visible = false;
            exitModiBTN.Visible = false;
        }

        private void exitModiBTN_Click(object sender, EventArgs e)
        {
            EndModification();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Branch b = Context.Branches
                .Where(b => b.Id == int.Parse(idTXT.Text))
                .Include(b => b.Departments)
                .Include(b => b.Classes)
                .SingleOrDefault();

                if (b.Departments.Count > 0) throw new Exception($"You cannot delete this branch since it contains {b.Departments.Count} {(b.Departments.Count == 1 ? "Department" : "Departments")}");
                if (b.Classes.Count > 0) throw new Exception($"You cannot delete this branch since it contains {b.Classes.Count} {(b.Classes.Count == 1 ? "Class" : "Classes")}");


                Context.Branches.Remove(b);
                Context.SaveChanges();
            }
            catch(Exception ex)
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

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
