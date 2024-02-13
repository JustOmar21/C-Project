﻿using C__Project.Models;
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
                        dataGridView.Rows.Clear();
                        dataGridView.Rows.Add(instructor.Id, instructor.Name, instructor.Title, instructor.Email, instructor.DOB, instructor.Salary);

                        // Optional: Adjust the DataGridView appearance if needed
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

                // Check if the entered salary is a valid double
                if (double.TryParse(txtSalary.Text, out double salary))
                {
                    // Gather date of birth from DateTimePicker
                    DateTime dob = pickDateTime.Value;

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
                    MessageBox.Show("Please enter a valid numeric salary.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbUpdateException ex)
            {
                // Display detailed exception information
                MessageBox.Show($"Error creating instructor: {ex.Message}\n\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Display generic exception information
                MessageBox.Show($"Error creating instructor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
