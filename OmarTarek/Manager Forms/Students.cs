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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace C__Project.OmarTarek
{
    public partial class Students : Form
    {
        Form previousForm;
        ExamSystemContext Context;
        Regex nameRegex = new Regex(@"^(?=.{3,50}$)[a-zA-Z0-9]+(?:[' -][a-zA-Z0-9]+)*$");
        Regex emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+(?:[a-zA-Z0-9-][a-zA-Z0-9._%+-]*@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4})$");
        public Students(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            Context = new ExamSystemContext();
            GetData();
            addBTN.Enabled = false;
            dobDP.MinDate = DateTime.Now.AddYears(-85).Date;
            dobDP.MaxDate = DateTime.Now.AddYears(-15).Date;
            dobDP.Value = dobDP.MaxDate.Date;
        }
        public void GetData()
        {
            dynamic classes = null;
            int? currentBranch = (int?)trackCB.SelectedValue == null ? null : Context.Tracks
                .Include(b => b.Department)
                .Where(trk => trk.Id == (int?)trackCB.SelectedValue).Select(t => (int?)t.Department.BranchId).FirstOrDefault();
            var intakes = Context.Intakes.Select(i => new { Name = i.Name, ID = i.Id }).OrderBy(i => i.Name).ToList();
            var tracks = Context.Tracks.Select(t => new { Name = t.Name, ID = t.Id }).OrderBy(t => t.Name).ToList();
            if (currentBranch != null)
            {
                classes = Context.Classes
                .Where(c => c.BranchId == currentBranch)
                .Select(c => new { Name = c.Name, ID = c.Id }).OrderBy(c => c.Name).ToList();
            }
            dataGridView1.DataSource = Context.Students
                .Include(student => student.Intake)
                .Include(student => student.Track)
                .Include(student => student.Class)
                .ThenInclude(c => c.Branch)
                .Where(student => student.Name.Contains(SearchTXT.Text.Trim()))
                .Select(student => new
                {
                    student.Id,
                    student.IntakeId,
                    student.TrackId,
                    student.ClassId,
                    student.Name,
                    student.Email,
                    student.DOB,
                    Intake = (string?)student.Intake.Name,
                    Track = (string?)student.Track.Name,
                    Class = (string?)student.Class.Name,
                    Branch = (string?)student.Class.Branch.Name
                })
                .OrderBy(student => student.Class)
                .ThenBy(student => student.Track)
                .ThenBy(student => student.Branch)
                .ThenBy(student => student.Intake)
                .ToList();

            intakeCB.DataSource = intakes;
            intakeCB.DisplayMember = "Name";
            intakeCB.SelectedIndex = -1;
            intakeCB.ValueMember = "ID";
            intakeCB.DropDownStyle = ComboBoxStyle.DropDownList;

            trackCB.DataSource = tracks;
            trackCB.DisplayMember = "Name";
            trackCB.SelectedIndex = -1;
            trackCB.ValueMember = "ID";
            trackCB.DropDownStyle = ComboBoxStyle.DropDownList;

            classCB.DataSource = classes;
            classCB.DisplayMember = "Name";
            classCB.SelectedIndex = -1;
            classCB.ValueMember = "ID";
            classCB.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["IntakeId"].Visible = false;
            dataGridView1.Columns["TrackId"].Visible = false;
            dataGridView1.Columns["ClassId"].Visible = false;
            dataGridView1.TopLeftHeaderCell.Value = "Edit";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AutoResizeColumns();

        }
        private void GetTrackClasses()
        {
            dynamic classes = null;
            int? currentBranch = (int?)trackCB.SelectedValue == null ? null : Context.Tracks
                .Include(b => b.Department)
                .Where(trk => trk.Id == (int?)trackCB.SelectedValue).Select(t => (int?)t.Department.BranchId).FirstOrDefault() ?? null;
            var tracks = Context.Tracks.Select(t => new { Name = t.Name, ID = t.Id }).OrderBy(t => t.Name).ToList();
            if (currentBranch != null)
            {
                classes = Context.Classes
                .Where(c => c.BranchId == currentBranch)
                .Select(c => new { Name = c.Name, ID = c.Id }).OrderBy(c => c.Name).ToList();
            }
            classCB.DataSource = classes;
        }

        private void Students_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }
        public void RegexTest()
        {
            bool nameVali = nameRegex.IsMatch(nameTXT.Text.Trim());
            bool emailVali = emailRegex.IsMatch(emailTXT.Text.Trim());

            if (nameVali && emailVali)
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

        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student()
                {
                    Name = nameTXT.Text.Trim(),
                    Email = emailTXT.Text.Trim(),
                    DOB = dobDP.Value.Date,
                    IntakeId = (int?)intakeCB.SelectedValue,
                    TrackId = (int?)trackCB.SelectedValue,
                    ClassId = (int?)classCB.SelectedValue
                };
                var doesEmailExist = Context.Students.Where(x => x.Email == s.Email);
                if(doesEmailExist.Count() > 0 ) { throw new Exception("The email you entered is already in use by another Student"); }
                Context.Students.Add(s);
                Context.SaveChanges();
                addStudentEmail(s);
                Context.SaveChanges();
            }
            catch(Exception ex)
            {
                if(ex.InnerException != null)
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
        private void addStudentEmail(Student s , string password = "123456789sS" )
        {
            Login log = new Login() { Email = s.Email , Password = password , Type ="Student"};
            Context.Logins.Add(log);
        }
        private void EndModification()
        {
            emailTXT.Text = nameTXT.Text = idTXT.Text = "";
            dobDP.Value = dobDP.MaxDate;
            nameValiLBL.Visible = false;
            emailValiLBL.Visible = false;
            intakeCB.SelectedIndex = -1;
            trackCB.SelectedIndex = -1;
            classCB.SelectedIndex = -1;
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
                intakeCB.SelectedValue = dataGridView1[1, e.RowIndex].Value ?? -1;
                trackCB.SelectedValue = dataGridView1[2, e.RowIndex].Value ?? -1;
                classCB.SelectedValue = dataGridView1[3, e.RowIndex].Value ?? -1;
                nameTXT.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                emailTXT.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                dobDP.Value = (DateTime)dataGridView1[6, e.RowIndex].Value;

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
                Student student = Context.Students.Where(student => student.Id == int.Parse(idTXT.Text)).SingleOrDefault();
                string oldEmail = student.Email;
                var doesEmailExist = Context.Students.Where(x => x.Email == emailTXT.Text.Trim() && x.Email != student.Email);
                if (doesEmailExist.Count() > 0) { throw new Exception("The email you entered is already in use by another Student"); }
                student.Name = nameTXT.Text.Trim();
                student.Email = emailTXT.Text.Trim();
                student.DOB = dobDP.Value.Date;
                student.IntakeId = (int?)intakeCB.SelectedValue;
                student.TrackId = (int?)trackCB.SelectedValue;
                student.ClassId = (int?)classCB.SelectedValue;
                Context.SaveChanges();
                updateStudentEmail(oldEmail, student);
                Context.SaveChanges();
                
            }
            catch(Exception ex)
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

        private void updateStudentEmail(string oldEmail , Student s)
        {
            var log = Context.Logins.Where(log=> log.Email == oldEmail && log.Type == "Student").SingleOrDefault();
            string password = log.Password;
            deleteStudentEmail(oldEmail);
            addStudentEmail(s, password);
            
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = Context.Students
                    .Where(student => student.Id == int.Parse(idTXT.Text))
                    .Include(student => student.Exams)
                    .SingleOrDefault();

                if (student.Exams.Count > 0) throw new Exception($"You cannot delete this student since this student has {student.Exams.Count} {(student.Exams.Count == 1 ? "Exam" : "Exams")}");

                deleteStudentEmail(student.Email);
                Context.SaveChanges();
                Context.Students.Remove(student);
                Context.SaveChanges();
            }
            catch(Exception ex)
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
        private void deleteStudentEmail(string email)
        {
            var log = Context.Logins.Where(log => log.Email == email && log.Type == "Student").SingleOrDefault();
            Context.Logins.Remove(log);
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

        private void trackCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTrackClasses();
        }

        private void intakeNullBTN_Click(object sender, EventArgs e)
        {
            intakeCB.SelectedIndex = -1;
        }

        private void trackNullBTN_Click(object sender, EventArgs e)
        {
            trackCB.SelectedIndex = -1;
        }

        private void classNullBTN_Click(object sender, EventArgs e)
        {
            classCB.SelectedIndex = -1;
        }
    }
}
