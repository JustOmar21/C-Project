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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace C__Project.OmarTarek.Manager_Forms
{
    public partial class AddManager : Form
    {
        Form previousForm;
        ExamSystemContext Context = new ExamSystemContext();
        Regex nameRegex = new Regex(@"^(?=.{3,50}$)[a-zA-Z0-9]+(?:[' -][a-zA-Z0-9]+)*$");
        Regex emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+(?:[a-zA-Z0-9-][a-zA-Z0-9._%+-]*@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4})$");
        Regex salaryRegex = new Regex(@"^(?:[4-9]\d{3,}|[1-9]\d{4,})$");
        public AddManager(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            GetData();
            addBTN.Enabled = false;
            dobDP.MinDate = DateTime.Now.AddYears(-85).Date;
            dobDP.MaxDate = DateTime.Now.AddYears(-21).Date;
            dobDP.Value = dobDP.MaxDate.Date;
            salaryTXT.Text = "4000";
        }

        public void GetData()
        {
            var managers = Context.Managers
                .Where(mgr => mgr.Name.Contains(SearchTXT.Text.Trim()))
                .Select(mgr => new { mgr.Id, mgr.Name, mgr.Email, mgr.DOB.Date, mgr.Title, Salary = $"{mgr.Salary} $" })
                .ToList();
            dataGridView1.DataSource = managers;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.TopLeftHeaderCell.Value = "Edit";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }

        private void AddManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }
        public void RegexTest()
        {
            bool nameVali = nameRegex.IsMatch(nameTXT.Text.Trim());
            bool emailVali = emailRegex.IsMatch(emailTXT.Text.Trim());
            bool salaryVali = salaryRegex.IsMatch(salaryTXT.Text.Trim());
            bool titleVali = nameRegex.IsMatch(titleTXT.Text.Trim());

            if (nameVali && emailVali && salaryVali && titleVali)
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

        private void emailTXT_TextChanged(object sender, EventArgs e)
        {
            bool emailVali = emailRegex.IsMatch(emailTXT.Text.Trim());
            if (emailVali) { emailValiLBL.Visible = false; } else { emailValiLBL.Visible = true; }
            RegexTest();
        }

        private void titleTXT_TextChanged(object sender, EventArgs e)
        {
            bool titleVali = nameRegex.IsMatch(titleTXT.Text.Trim());
            if (titleVali) { titleValiLBL.Visible = false; } else { titleValiLBL.Visible = true; }
            RegexTest();
        }

        private void salaryTXT_TextChanged(object sender, EventArgs e)
        {
            bool salaryVali = salaryRegex.IsMatch(salaryTXT.Text.Trim());
            if (salaryVali) { salaryValiLBL.Visible = false; } else { salaryValiLBL.Visible = true; }
            RegexTest();
        }
        private void EndModification()
        {
            titleTXT.Text = emailTXT.Text = nameTXT.Text = idTXT.Text = "";
            salaryTXT.Text = "4000";
            dobDP.Value = dobDP.MaxDate;
            nameValiLBL.Visible = false;
            emailValiLBL.Visible = false;
            salaryValiLBL.Visible = false;
            titleValiLBL.Visible = false;
            addBTN.Visible = true;
            updateBTN.Visible = false;
            deleteBTN.Visible = false;
            exitModiBTN.Visible = false;
        }
        private void addManagerEmail(Manager m, string password = "123456789sS")
        {
            Login log = new Login() { Email = m.Email, Password = password, Type = "Manager" };
            Context.Logins.Add(log);
        }
        private void updateManagerEmail(string oldEmail, Manager m)
        {
            var log = Context.Logins.Where(log => log.Email == oldEmail && log.Type == "Manager").SingleOrDefault();
            string password = log.Password;
            deleteManagerEmail(oldEmail);
            addManagerEmail(m, password);
        }
        private void deleteManagerEmail(string email)
        {
            var log = Context.Logins.Where(log => log.Email == email && log.Type == "Manager").SingleOrDefault();
            Context.Logins.Remove(log);
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Manager manager = new Manager()
                {
                    Name = nameTXT.Text.Trim(),
                    Email = emailTXT.Text.Trim(),
                    DOB = dobDP.Value.Date,
                    Title = titleTXT.Text.Trim(),
                    Salary = float.Parse(salaryTXT.Text.Trim()),
                };
                var doesEmailExist = Context.Managers.Where(x => x.Email == manager.Email);
                if (doesEmailExist.Count() > 0) { throw new Exception("The email you entered is already in use by another Manager"); }
                Context.Managers.Add(manager);
                Context.SaveChanges();
                addManagerEmail(manager);
                Context.SaveChanges();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                idTXT.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                nameTXT.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                emailTXT.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                dobDP.Value = (DateTime)dataGridView1[3, e.RowIndex].Value;
                titleTXT.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                salaryTXT.Text = dataGridView1[5, e.RowIndex].Value.ToString().Split()[0];

                addBTN.Visible = false;
                updateBTN.Visible = true;
                deleteBTN.Visible = true;
                exitModiBTN.Visible = true;
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Manager manager = Context.Managers.Where(manager => manager.Id == int.Parse(idTXT.Text)).SingleOrDefault();
                string oldEmail = manager.Email;
                var doesEmailExist = Context.Managers.Where(x => x.Email == emailTXT.Text.Trim() && x.Email != manager.Email);
                if (doesEmailExist.Count() > 0) { throw new Exception("The email you entered is already in use by another Manager"); }
                manager.Name = nameTXT.Text.Trim();
                manager.Email = emailTXT.Text.Trim();
                manager.DOB = dobDP.Value.Date;
                manager.Title = titleTXT.Text.Trim();
                manager.Salary = float.Parse(salaryTXT.Text.Trim());
                Context.SaveChanges();
                updateManagerEmail(oldEmail, manager);
                Context.SaveChanges();

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
            try
            {
                Manager manager = Context.Managers
                    .Where(manager => manager.Id == int.Parse(idTXT.Text))
                    .SingleOrDefault();

                deleteManagerEmail(manager.Email);
                Context.SaveChanges();
                Context.Managers.Remove(manager);
                Context.SaveChanges();
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

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            GetData();
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
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            int rowHeight = dataGridView1.RowTemplate.Height;
            int x = 10;
            int y = 50;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(x, y, 150, rowHeight));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, 150, rowHeight));
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText,
                                      dataGridView1.Font,
                                      Brushes.Black,
                                      new RectangleF(x + 2, y, 150, rowHeight),
                                      new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                x += 150;
            }
            x = 10;
            y += rowHeight;

            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {

                for (int i = 0; i < rows.Cells.Count; i++)
                {
                    if (i == 5)
                    {
                        e.Graphics.FillRectangle(Brushes.White, new Rectangle(x, y, 150, rowHeight));
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, 150, rowHeight));
                        e.Graphics.DrawString(rows.Cells[i].Value.ToString(),
                                          dataGridView1.Font,
                                          Brushes.Black,
                                          new RectangleF(x + 2, y, 150, rowHeight),
                                          new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                        x += 150;
                    }
                    else
                    {
                        e.Graphics.FillRectangle(Brushes.White, new Rectangle(x, y, 150, rowHeight));
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, 150, rowHeight));
                        e.Graphics.DrawString(i != 3 ? rows.Cells[i].Value.ToString() : rows.Cells[i].Value.ToString().Split(" ").First(),
                                          dataGridView1.Font,
                                          Brushes.Black,
                                          new RectangleF(x + 2, y, 150, rowHeight),
                                          new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                        x += 150;
                    }
                }
                x = 10;
                y += rowHeight;

            }
        }

        private void exitModiBTN_Click(object sender, EventArgs e)
        {
            EndModification();
        }
    }
}
