﻿using C__Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project.OmarTarek.Student_Forms
{
    public partial class StudentProfile : Form
    {
        ExamSystemContext Context = new ExamSystemContext();
        Student student;
        Form previousForm;
        public StudentProfile(Form previousForm)
        {
            InitializeComponent();
            int StudentID = 1; // replace this with a static variable of CurrentUserID
            this.student = Context.Students
                .Include(std => std.Class)
                .Include(std => std.Intake)
                .Include(std => std.Track)
                .SingleOrDefault(std => std.Id == StudentID);
            IDTXT.Text = student.Id.ToString();
            nameTXT.Text = student.Name;
            emailTXT.Text = student.Email;
            dobTXT.Text = student.DOB.Date.ToString().Split(" ").First();
            intakeTXT.Text = student.Intake?.Name;
            classTXT.Text = student.Class?.Name;
            trackTXT.Text = student.Track?.Name;
            this.previousForm = previousForm;
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }
    }
}