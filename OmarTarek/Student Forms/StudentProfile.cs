using C__Project.FaresAwad;
using C__Project.Models;
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
            int StudentID = UserSession.Id; // replace this with a static variable of CurrentUserID
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

        private void classesBTN_Click(object sender, EventArgs e)
        {
            StudentClasses studentClasses = new StudentClasses(this);
            this.Hide();
            studentClasses.Show();
        }

        private void examsBTN_Click(object sender, EventArgs e)
        {
            StudentExams student = new StudentExams(this);
            this.Hide();
            student.Show();
        }
    }
}
