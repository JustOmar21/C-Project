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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace C__Project.OmarTarek
{
    public partial class Tracks : Form
    {
        Form previousForm;
        ExamSystemContext Context;
        Regex TrackRegex = new Regex(@"^(?=.{3,50}$)[a-zA-Z0-9]+(?:[' -][a-zA-Z0-9]+)*$");
        public Tracks(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            Context = new ExamSystemContext();
            GetData();
            addBTN.Enabled = false;
        }
        public void GetData()
        {
            var departments = Context.Departments.Select(b => new { Name = b.Name, ID = b.Id }).OrderBy(b => b.Name).ToList();
            dataGridView1.DataSource =
                Context.Tracks.Include(track => track.Department)
                .ThenInclude(dept => dept.Branch)
                .Where(track => track.Name.Contains(SearchTXT.Text.Trim()))
                .Select(track => new
                {
                    track.Id,
                    DeptID = track.DepartmentId,
                    track.Name,
                    Department = track.Department.Name,
                    Branch = track.Department.Branch.Name,
                    track.Description
                })
                .OrderBy(track => track.Branch)
                .ThenBy(track => track.Department)
                .ToList();
            deptCB.DataSource = departments;
            deptCB.DisplayMember = "Name";
            deptCB.SelectedIndex = 0;
            deptCB.ValueMember = "ID";
            deptCB.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["DeptID"].Visible = false;
            dataGridView1.TopLeftHeaderCell.Value = "Edit";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.AutoResizeColumns();
        }

        private void Tracks_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }
        public void RegexTest()
        {
            bool nameVali = TrackRegex.IsMatch(nameTXT.Text.Trim());
            bool descVali = descTXT.Text.Trim() != "";

            if (nameVali && descVali)
            { addBTN.Enabled = true; updateBTN.Enabled = true; }
            else
            { addBTN.Enabled = false; updateBTN.Enabled = false; }

        }

        private void nameTXT_TextChanged(object sender, EventArgs e)
        {
            bool nameVali = TrackRegex.IsMatch(nameTXT.Text.Trim());
            if (nameVali) { nameValiLBL.Visible = false; } else { nameValiLBL.Visible = true; }
            RegexTest();
        }

        private void descTXT_TextChanged(object sender, EventArgs e)
        {
            bool descVali = descTXT.Text.Trim() != "";
            if (descVali) { descValiLBL.Visible = false; } else { descValiLBL.Visible = true; }
            RegexTest();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            Track track = new Track()
            {
                Name = nameTXT.Text.Trim(),
                Description = descTXT.Text.Trim(),
                DepartmentId = (int)deptCB.SelectedValue
            };
            Context.Tracks.Add(track);
            Context.SaveChanges();
            EndModification();
            GetData();
        }
        private void EndModification()
        {
            nameTXT.Text = idTXT.Text = descTXT.Text = "";
            nameValiLBL.Visible = descValiLBL.Visible = false;
            deptCB.SelectedIndex = 0;
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
                deptCB.SelectedValue = dataGridView1[1, e.RowIndex].Value;
                nameTXT.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                descTXT.Text = dataGridView1[3, e.RowIndex].Value.ToString();

                addBTN.Visible = false;
                updateBTN.Visible = true;
                deleteBTN.Visible = true;
                exitModiBTN.Visible = true;
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {

            Track track = Context.Tracks
             .Where(track => track.Id == int.Parse(idTXT.Text))
             .SingleOrDefault();

            track.Name = nameTXT.Text.Trim();
            track.Description = descTXT.Text.Trim();
            track.DepartmentId = (int)deptCB.SelectedValue;
            Context.SaveChanges();
            EndModification();
            GetData();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Track track = Context.Tracks
                .Where(track => track.Id == int.Parse(idTXT.Text))
                .Include(track => track.Students)
                .SingleOrDefault();

                if (track.Students.Count > 0) throw new Exception($"You cannot delete this Track since it contains {track.Students.Count} {(track.Students.Count == 1 ? "Student" : "Students")}");

                Context.Tracks.Remove(track);
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
                if (i == 1)
                {
                    continue;
                }
                else
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
            }
            x = 50;
            y += rowHeight;

            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {

                for (int i = 0; i < rows.Cells.Count; i++)
                {
                    if(i == 1)
                    {
                        continue;
                    }
                    else
                    {
                        e.Graphics.FillRectangle(Brushes.White, new Rectangle(x, y, 150, rowHeight));
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, 150, rowHeight));
                        e.Graphics.DrawString(rows.Cells[i].Value.ToString(),
                                          dataGridView1.Font,
                                          Brushes.Black,
                                          new RectangleF(x + 20, y, 150, rowHeight),
                                          new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                        x += 150;
                    }
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
