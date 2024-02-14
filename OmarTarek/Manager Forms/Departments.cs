using C__Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project.OmarTarek
{
    public partial class Departments : Form
    {
        Form previousForm;
        ExamSystemContext Context;
        Regex DepartmentRegex = new Regex(@"^(?=.{3,50}$)[a-zA-Z0-9]+(?:[' -][a-zA-Z0-9]+)*$");
        public Departments(Form previousForm)
        {

            InitializeComponent();
            this.previousForm = previousForm;
            Context = new ExamSystemContext();
            GetData();
            addBTN.Enabled = false;

        }

        public void GetData()
        {
            var branches = Context.Branches.Select(b => new { Name = b.Name, ID = b.Id }).OrderBy(b => b.Name).ToList();
            dataGridView1.DataSource = Context.Departments.Include(dept => dept.Branch).Where(dept => dept.Name.Contains(SearchTXT.Text.Trim())).Select(dept => new { dept.Id, dept.Name, Branch = dept.Branch.Name, BranchID = dept.BranchId }).OrderBy(dept => dept.Branch).ToList();
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
            bool nameVali = DepartmentRegex.IsMatch(nameTXT.Text.Trim());

            if (nameVali)
            { addBTN.Enabled = true; updateBTN.Enabled = true; }
            else
            { addBTN.Enabled = false; updateBTN.Enabled = false; }

        }

        private void nameTXT_TextChanged(object sender, EventArgs e)
        {
            bool nameVali = DepartmentRegex.IsMatch(nameTXT.Text.Trim());
            if (nameVali) { nameValiLBL.Visible = false; } else { nameValiLBL.Visible = true; }
            RegexTest();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            Department dept = new Department() { Name = nameTXT.Text.Trim(), BranchId = (int)branchCB.SelectedValue };
            Context.Departments.Add(dept);
            Context.SaveChanges();
            EndModification();
            GetData();

        }
        private void EndModification()
        {
            nameTXT.Text = idTXT.Text = "";
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
                branchCB.SelectedValue = dataGridView1[3, e.RowIndex].Value;

                addBTN.Visible = false;
                updateBTN.Visible = true;
                deleteBTN.Visible = true;
                exitModiBTN.Visible = true;
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            Department dept = Context.Departments.Where(dept => dept.Id == int.Parse(idTXT.Text)).SingleOrDefault();
            dept.Name = nameTXT.Text.Trim();
            dept.BranchId = (int)branchCB.SelectedValue;
            Context.SaveChanges();
            EndModification();
            GetData();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = Context.Departments
                .Where(dept => dept.Id == int.Parse(idTXT.Text))
                .Include(dept => dept.Tracks)
                .SingleOrDefault();

                if (dept.Tracks.Count > 0) throw new Exception($"You cannot delete this department since it contains {dept.Tracks.Count} {(dept.Tracks.Count == 1 ? "Track" : "Tracks")}");

                Context.Departments.Remove(dept);
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
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            int rowHeight = dataGridView1.RowTemplate.Height;
            int x = 50;
            int y = 50;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(x, y, 150, rowHeight));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, 150, rowHeight));
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText,
                                      dataGridView1.Font,
                                      Brushes.Black,
                                      new RectangleF(x + 40, y, 150, rowHeight),
                                      new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                x += 150;
            }
            x = 50;
            y += rowHeight;

            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {

                for (int i = 0; i < rows.Cells.Count; i++)
                {
                    e.Graphics.FillRectangle(Brushes.White, new Rectangle(x, y, 150, rowHeight));
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, 150, rowHeight));
                    e.Graphics.DrawString(rows.Cells[i].Value.ToString(),
                                      dataGridView1.Font,
                                      Brushes.Black,
                                      new RectangleF(x + 40, y, 150, rowHeight),
                                      new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                    x += 150;
                }
                x = 50;
                y += rowHeight;

            }
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            printDocument.PrintPage += PrintDocument_PrintPage;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Show print preview
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
        }
    }
}
