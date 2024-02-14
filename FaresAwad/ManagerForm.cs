using C__Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace C__Project.FaresAwad
{
    public partial class ManagerForm : Form
    {
        private ExamSystemContext dbContext;  // Assuming your DbContext is named ExamSystemContext

        public ManagerForm()
        {
            InitializeComponent();
            dbContext = new ExamSystemContext();  // Initialize your DbContext
            LoadInstructors();  // Call the method to load instructors into DataGridView
        }

        private void LoadInstructors()
        {
            try
            {
                // Retrieve all instructors from the database
                var instructors = dbContext.Instructors.ToList();

                // Bind the list of instructors to the DataGridView
                dataGridView.DataSource = instructors;

                // Optional: Adjust the DataGridView appearance if needed
                dataGridView.Columns["Exams"].Visible = false;  // Assuming you don't want to show the Exams column
                dataGridView.Columns["Questions"].Visible = false;  // Assuming you don't want to show the Questions column
                dataGridView.Columns["TeachesClass"].Visible = false;  // Assuming you don't want to show the TeachesClass column
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading instructors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event if needed
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the ID entered in the txtId TextBox
                if (int.TryParse(txtId.Text, out int instructorId))
                {
                    // Search for the instructor by ID in the database
                    var instructor = dbContext.Instructors.Find(instructorId);

                    if (instructor != null)
                    {
                        // Clear the DataGridView
                        dataGridView.DataSource = null;

                        // Display the found instructor in the DataGridView
                        var instructors = new List<Instructor> { instructor };
                        dataGridView.DataSource = instructors;

                        dataGridView.Columns["Exams"].Visible = false;
                        dataGridView.Columns["Questions"].Visible = false;
                        dataGridView.Columns["TeachesClass"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show($"Instructor with ID {instructorId} not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for instructor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather values from the TextBoxes and DateTimePicker
                string name = txtName.Text;
                string title = txtTitle.Text;
                string email = txtEmail.Text;

                // Check if the entered email already exists in the Login table
                var existingLogin = dbContext.Logins.Find(email, "Instructor");

                if (existingLogin == null)
                {
                    // Email doesn't exist, proceed with creating a new instructor and login
                    // Check if the entered salary is a valid double
                    if (float.TryParse(txtSalary.Text, out float salary))
                    {
                        // Gather date of birth from DateTimePicker
                        DateTime dob = pickDateTime.Value;

                        // Check if the instructor meets the minimum age requirement (21 years)
                        if (IsMinimumAgeValid(dob))
                        {
                            // Create a new Login object for the new instructor
                            var newLogin = new Login
                            {
                                Email = email,
                                Type = "Instructor",
                                Password = "DefaultPassword"  // You should handle password more securely in a real application
                            };

                            // Add the new login to the Login table
                            dbContext.Logins.Add(newLogin);

                            // Create a new Instructor object
                            var newInstructor = new Instructor
                            {
                                Name = name,
                                Title = title,
                                Email = email,
                                DOB = dob,
                                Salary = salary
                            };

                            // Add the new instructor to the database
                            dbContext.Instructors.Add(newInstructor);

                            // Save changes and get the number of affected rows
                            int affectedRows = dbContext.SaveChanges();

                            if (affectedRows > 0)
                            {
                                // Changes saved successfully
                                MessageBox.Show("Instructor created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadInstructors(); // Refresh the DataGridView with the updated data
                            }
                            else
                            {
                                MessageBox.Show("No changes were made to the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Instructor must be at least 21 years old.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid numeric salary.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Email already exists, show a message to the user
                    MessageBox.Show($"Email '{email}' already exists. Please choose a different email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                // Display detailed exception information
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Database error: {ex.InnerException.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Database error: {ex.Message}\n\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display generic exception information
                MessageBox.Show($"Error creating instructor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsMinimumAgeValid(DateTime dob)
        {
            // Check if the instructor is at least 21 years old
            return (DateTime.Now - dob).TotalDays / 365.25 >= 21;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the instructor ID from the textInsId TextBox
                if (int.TryParse(textInsId.Text, out int instructorId))
                {
                    // Search for the instructor by ID in the database
                    var instructorToUpdate = dbContext.Instructors.Find(instructorId);

                    if (instructorToUpdate != null)
                    {
                        // Gather updated values from the TextBoxes and DateTimePicker
                        string name = txtName.Text;
                        string title = txtTitle.Text;
                        string email = txtEmail.Text;

                        // Check if the entered salary is a valid double
                        if (float.TryParse(txtSalary.Text, out float salary))
                        {
                            // Gather date of birth from DateTimePicker
                            DateTime dob = pickDateTime.Value;

                            // Check if the instructor meets the minimum age requirement (21 years)
                            if (IsMinimumAgeValid(dob))
                            {
                                // Check if the email exists in the Login table
                                var loginEntry = dbContext.Logins.FirstOrDefault(l => l.Email == email && l.Type == "Instructor");

                                if (loginEntry == null)
                                {
                                    // If the email doesn't exist, add it to the Login table
                                    var newLogin = new Login
                                    {
                                        Email = email,
                                        Type = "Instructor",
                                        Password = "YourDefaultPassword" // You should set a default password here
                                    };

                                    dbContext.Logins.Add(newLogin);
                                }

                                // Update the properties of the existing instructor
                                instructorToUpdate.Name = name;
                                instructorToUpdate.Title = title;
                                instructorToUpdate.Email = email;
                                instructorToUpdate.DOB = dob;
                                instructorToUpdate.Salary = salary;

                                // Save changes and get the number of affected rows
                                int affectedRows = dbContext.SaveChanges();

                                if (affectedRows > 0)
                                {
                                    // Changes saved successfully
                                    MessageBox.Show("Instructor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadInstructors(); // Refresh the DataGridView with the updated data
                                }
                                else
                                {
                                    MessageBox.Show("No changes were made to the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Instructor must be at least 21 years old.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid numeric salary.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Instructor with ID {instructorId} not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                // Display detailed exception information
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Database error: {ex.InnerException.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Database error: {ex.Message}\n\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display generic exception information
                MessageBox.Show($"Error updating instructor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the instructor ID from the textInsId TextBox
                if (int.TryParse(textInsId.Text, out int instructorId))
                {
                    // Search for the instructor by ID in the database
                    var instructorToDelete = dbContext.Instructors.Find(instructorId);

                    if (instructorToDelete != null)
                    {
                        // Check if the email exists in the Login table
                        var loginEntry = dbContext.Logins.FirstOrDefault(l => l.Email == instructorToDelete.Email && l.Type == "Instructor");

                        // If the email exists, remove the corresponding entry from the Login table
                        if (loginEntry != null)
                        {
                            dbContext.Logins.Remove(loginEntry);
                        }

                        // Remove the instructor from the Instructors table
                        dbContext.Instructors.Remove(instructorToDelete);

                        // Save changes and get the number of affected rows
                        int affectedRows = dbContext.SaveChanges();

                        if (affectedRows > 0)
                        {
                            // Changes saved successfully
                            MessageBox.Show("Instructor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadInstructors(); // Refresh the DataGridView with the updated data
                        }
                        else
                        {
                            MessageBox.Show("No changes were made to the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Instructor with ID {instructorId} not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                // Display detailed exception information
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Database error: {ex.InnerException.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Database error: {ex.Message}\n\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display generic exception information
                MessageBox.Show($"Error deleting instructor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
