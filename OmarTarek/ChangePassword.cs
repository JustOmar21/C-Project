using C__Project.FaresAwad;
using C__Project.Models;
using C__Project.OmarTarek.Admin_Forms;
using C__Project.OmarTarek.Manager_Forms;
using C__Project.OmarTarek.Student_Forms;
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
    public partial class ChangePassword : Form
    {
        ExamSystemContext Context = new ExamSystemContext();
        Form previousForm;
        Regex password = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
        public ChangePassword(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }
        public void RegexTest()
        {
            bool oldPassVali = password.IsMatch(oldPassTXT.Text);
            bool newPassVali = password.IsMatch(newPassTXT.Text);
            bool newPassAgainVali = newPassTXT.Text == newPassAgainTXT.Text;

            if (oldPassVali && newPassVali && newPassAgainVali)
            {
                changeBTN.Enabled = true;
            }
            else
            {
                changeBTN.Enabled = false;
            }
        }

        private void oldPassTXT_TextChanged(object sender, EventArgs e)
        {
            bool oldPassVali = password.IsMatch(oldPassTXT.Text);
            if (oldPassVali) { oldPassValiLBL.Visible = false; } else { oldPassValiLBL.Visible = true; }
            RegexTest();
        }

        private void newPassTXT_TextChanged(object sender, EventArgs e)
        {
            bool newPassVali = password.IsMatch(newPassTXT.Text);
            if (newPassVali) { newPassValiLBL.Visible = false; } else { newPassValiLBL.Visible = true; }
            RegexTest();
        }

        private void newPassAgainTXT_TextChanged(object sender, EventArgs e)
        {
            bool newPassAgainVali = newPassTXT.Text == newPassAgainTXT.Text;
            if (newPassAgainVali) { confirmPassLBL.Visible = false; } else { confirmPassLBL.Visible = true; }
            RegexTest();
        }
        private void changePassword(string email, string type)
        {
            Login log = Context.Logins.SingleOrDefault(log => log.Email == email && log.Type == type);
            if (log.Password == oldPassTXT.Text)
            {
                log.Password = newPassTXT.Text;
                Context.SaveChanges();
                MessageBox.Show("Password changed successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                throw new Exception("The password you entered is wrong");
            }
        }

        private void changeBTN_Click(object sender, EventArgs e)
        {
            try
            {
                switch (UserSession.Type)
                {
                    case "Admin":
                        // admin will not access this
                        break;

                    case "Manager":
                        string managerEmail = Context.Managers.Where(mgr => mgr.Id == UserSession.Id).Select(mgr => mgr.Email).FirstOrDefault();
                        changePassword(managerEmail, UserSession.Type);
                        break;

                    case "Instructor":
                        string instructorEmail = Context.Instructors.Where(ins => ins.Id == UserSession.Id).Select(ins => ins.Email).FirstOrDefault();
                        changePassword(instructorEmail, UserSession.Type);
                        break;

                    case "Student":
                        string studentEmail = Context.Students.Where(std => std.Id == UserSession.Id).Select(std => std.Email).FirstOrDefault();
                        changePassword(studentEmail, UserSession.Type);
                        break;
                }
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
                oldPassTXT.Text = newPassTXT.Text = newPassAgainTXT.Text = "";
                oldPassValiLBL.Visible = newPassValiLBL.Visible = confirmPassLBL.Visible = false;
            }
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
