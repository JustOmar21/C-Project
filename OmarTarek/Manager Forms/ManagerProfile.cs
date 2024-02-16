using C__Project.FaresAwad;
using C__Project.Khateep;
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

namespace C__Project.OmarTarek.Manager_Forms
{
    public partial class ManagerProfile : Form
    {
        ExamSystemContext Context = new ExamSystemContext();
        Manager manager;
        Form previousForm;
        public ManagerProfile(Form previousForm)
        {
            InitializeComponent();
            int managerID = UserSession.Id;
            manager = Context.Managers.FirstOrDefault(x => x.Id == managerID);
            IDTXT.Text = manager.Id.ToString();
            nameTXT.Text = manager.Name;
            emailTXT.Text = manager.Email;
            dobTXT.Text = manager.DOB.Date.ToString().Split(" ")[0];
            salaryTXT.Text = manager.Salary.ToString() + "$";
            this.previousForm = previousForm;
        }

        private void branchBTN_Click(object sender, EventArgs e)
        {
            Branches b = new Branches(this);
            this.Hide();
            b.Show();
        }

        private void deptBTN_Click(object sender, EventArgs e)
        {
            var branches = Context.Branches.Select(b => new { Name = b.Name, ID = b.Id }).ToList();
            if (branches.Count == 0)
            {
                MessageBox.Show("You Cannot Add any Department beacause no Branches exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Departments dept = new Departments(this);
                this.Hide();
                dept.Show();
            }
        }

        private void trackBTN_Click(object sender, EventArgs e)
        {
            var department = Context.Departments.Select(b => b).ToList();
            if (department.Count == 0)
            {
                MessageBox.Show("You Cannot Add any Tracks beacause no Department exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Tracks track = new Tracks(this);
                this.Hide();
                track.Show();
            }
        }

        private void coursesBTN_Click(object sender, EventArgs e)
        {
            Courses course = new Courses(this);
            this.Hide();
            course.Show();
        }

        private void studentBTN_Click(object sender, EventArgs e)
        {
            Students student = new Students(this);
            this.Hide();
            student.Show();
        }

        private void intakeBTN_Click(object sender, EventArgs e)
        {
            Intakes intake = new Intakes(this);
            this.Hide();
            intake.Show();
        }

        private void classesBTN_Click(object sender, EventArgs e)
        {
            var branches = Context.Branches.Select(b => new { Name = b.Name, ID = b.Id }).ToList();
            if (branches.Count == 0)
            {
                MessageBox.Show("You Cannot Add any Department beacause no Branches exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Classes Class = new Classes(this);
                this.Hide();
                Class.Show();
            }
        }
        private void returnBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ManagerProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }

        private void instructorsBTN_Click(object sender, EventArgs e)
        {
            AddInstructors ins = new AddInstructors(this);
            this.Hide();
            ins.Show();
        }
    }
}
