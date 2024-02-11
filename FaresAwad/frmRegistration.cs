using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace C__Project.FaresAwad
{
    public partial class frmRegister : Form
    {
        private bool isPasswordHidden = true; // Set password to hidden initially
        private bool isComPasswordHidden = true; // Set confirm password to hidden initially

        public frmRegister()
        {
            InitializeComponent();

            // Hide the passwords initially
            isPasswordHidden = true;
            isComPasswordHidden = true;
            UpdatePasswordVisibility();
            UpdateComPasswordVisibility();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password and confirm password visibility based on checkbox state
            isPasswordHidden = !checkbxShowPas.Checked;
            isComPasswordHidden = !checkbxShowPas.Checked;
            UpdatePasswordVisibility();
            UpdateComPasswordVisibility();
        }

        private void UpdatePasswordVisibility()
        {
            // Set the password visibility based on the current state
            txtPassword.PasswordChar = isPasswordHidden ? '*' : '\0';
        }

        private void UpdateComPasswordVisibility()
        {
            // Set the confirm password visibility based on the current state
            txtComPassword.PasswordChar = isComPasswordHidden ? '*' : '\0';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Basic input validation
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtComPassword.Text) || cmbUserType.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter valid email, password, confirm password, and select user type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if passwords match
            if (txtPassword.Text != txtComPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please enter matching passwords.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Replace the placeholder connection string with your actual connection string
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-RR5U94D;Initial Catalog=\"TBN Exam System\";Integrated Security=True;TrustServerCertificate=True;"))
                {
                    con.Open();

                    // Check if the email is already registered
                    string checkEmailQuery = "SELECT COUNT(*) FROM Logins WHERE Email = @Email";
                    using (SqlCommand checkEmailCommand = new SqlCommand(checkEmailQuery, con))
                    {
                        checkEmailCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 450).Value = txtEmail.Text;
                        int emailCount = (int)checkEmailCommand.ExecuteScalar();

                        if (emailCount > 0)
                        {
                            MessageBox.Show("Email is already registered. Please use a different email.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user into the database
                    string insertQuery = "INSERT INTO Logins (Email, Password, Type) VALUES (@Email, @Password, @UserType)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, con))
                    {
                        insertCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 450).Value = txtEmail.Text;
                        insertCommand.Parameters.Add("@Password", SqlDbType.NVarChar, -1).Value = txtPassword.Text; // -1 for MAX
                        insertCommand.Parameters.Add("@UserType", SqlDbType.NVarChar, 450).Value = cmbUserType.SelectedItem.ToString();

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful. You can now log in.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes and reset combobox
            txtEmail.Clear();
            txtPassword.Clear();
            txtComPassword.Clear(); // Clear confirmation password
            cmbUserType.SelectedIndex = -1;
        }

        private void lblBacktoLogin_Click(object sender, EventArgs e)
        {
            // Hide current form and open Login form
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.ShowDialog();
        }
    }
}


