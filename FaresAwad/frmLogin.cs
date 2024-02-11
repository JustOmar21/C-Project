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
                        var userType = dbContext.Logins
                            .Where(l => l.Email == txtEmail.Text && l.Password == txtPassword.Text)
                            .Select(l => l.Type)
                            .FirstOrDefault();

                        if (userType != null)
                        {
                            switch (userType)
                            {
                                case "Admin":
                                    this.Hide();
                                    AdminForm adminForm = new AdminForm();
                                    adminForm.ShowDialog();
                                    break;

                                case "Manager":
                                    this.Hide();
                                    ManagerForm managerForm = new ManagerForm();
                                    managerForm.ShowDialog();
                                    break;

                                case "Instructor":
                                    this.Hide();
                                    InstructorForm instructorForm = new InstructorForm();
                                    instructorForm.ShowDialog();
                                    break;

                                case "Student":
                                    this.Hide();
                                    StudentForm studentForm = new StudentForm();
                                    studentForm.ShowDialog();
                                    break;

                                default:
                                    MessageBox.Show("Invalid user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
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