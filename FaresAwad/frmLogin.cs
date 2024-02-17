using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using C__Project.Models;
using Microsoft.EntityFrameworkCore;
using C__Project.OmarTarek.Student_Forms;
using C__Project.OmarTarek.Manager_Forms;
using C__Project.OmarTarek.Admin_Forms;

namespace C__Project.FaresAwad
{
    public partial class frmLogin : Form
    {
        private bool isPasswordHidden = true; // Set password to hidden initially

        public frmLogin()
        {
            InitializeComponent();

            // Hide the password initially
            isPasswordHidden = true;
            UpdatePasswordVisibility();
            cmbUserType.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Basic input validation
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || cmbUserType.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter valid email, password, and select user type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var dbContext = new ExamSystemContext())
                {
                    var userCount = dbContext.Logins
                        .Where(l => l.Email == txtEmail.Text && l.Password == txtPassword.Text && l.Type == cmbUserType.Text)
                        .Count();

                    if (userCount == 1)
                    {
                        var userType = cmbUserType.Text;

                        if (userType != null)
                        {
                            switch (userType)
                            {
                                case "Admin":
                                    UserSession.Id = -1;
                                    UserSession.Type = userType;
                                    this.Hide();
                                    AdminProfile adminForm = new AdminProfile(this);
                                    adminForm.Show();
                                    break;

                                case "Manager":
                                    var managerId = dbContext.Managers
                                        .Where(mgr => mgr.Email == txtEmail.Text)
                                        .Select(mgr => mgr.Id)
                                        .FirstOrDefault();

                                    UserSession.Id = managerId;
                                    UserSession.Type = userType;
                                    this.Hide();
                                    ManagerProfile managerForm = new ManagerProfile(this);
                                    managerForm.Show();
                                    break;

                                case "Instructor":
                                    var instructorId = dbContext.Instructors
                                        .Where(ins => ins.Email == txtEmail.Text)
                                        .Select(ins => ins.Id)
                                        .FirstOrDefault();

                                    UserSession.Id = instructorId;
                                    UserSession.Type = userType;

                                    this.Hide();
                                    InstructorForm instructorForm = new InstructorForm(this);
                                    instructorForm.Show();
                                    break;

                                case "Student":
                                    var studentId = dbContext.Students
                                        .Where(std => std.Email == txtEmail.Text)
                                        .Select(std => std.Id)
                                        .FirstOrDefault();

                                    UserSession.Id = studentId;
                                    UserSession.Type = userType;
                                    this.Hide();
                                    StudentProfile studentProfile = new StudentProfile(this);
                                    studentProfile.Show();
                                    break;

                                default:
                                    MessageBox.Show("Invalid user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                            ResetFields();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid login credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFields()
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            cmbUserType.SelectedIndex = 0;
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility based on checkbox state
            isPasswordHidden = !checkbxShowPas.Checked;
            UpdatePasswordVisibility();
        }

        private void UpdatePasswordVisibility()
        {
            // Set the password visibility based on the current state
            txtPassword.PasswordChar = isPasswordHidden ? '*' : '\0';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear all textboxes and reset combobox
            txtEmail.Clear();
            txtPassword.Clear();
            cmbUserType.SelectedIndex = -1;
        }
    }
}