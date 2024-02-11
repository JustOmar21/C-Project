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
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-RR5U94D;Initial Catalog=\"TBN Exam System\";Integrated Security=True;TrustServerCertificate=True;"))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM Logins WHERE Email = @Email and Password = @Password and Type = @UserType";

                    using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                    {
                        sda.SelectCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                        sda.SelectCommand.Parameters.AddWithValue("@Password", txtPassword.Text);
                        sda.SelectCommand.Parameters.AddWithValue("@UserType", cmbUserType.Text);

                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) == 1)
                        {
                            string userTypeQuery = "SELECT Type FROM Logins WHERE Email = @Email and Password = @Password";
                            using (SqlDataAdapter sda1 = new SqlDataAdapter(userTypeQuery, con))
                            {
                                sda1.SelectCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                                sda1.SelectCommand.Parameters.AddWithValue("@Password", txtPassword.Text);

                                DataTable dt1 = new DataTable();
                                sda1.Fill(dt1);

                                if (dt1.Rows.Count > 0)
                                {
                                    string userType = dt1.Rows[0][0].ToString();

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
                        }
                        else
                        {
                            MessageBox.Show("Invalid login credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void label6_Click(object sender, EventArgs e)
        {
            // Hide current form and open registration form
            this.Hide();
            frmRegister registrationForm = new frmRegister();
            registrationForm.Show();
        }
    }
}