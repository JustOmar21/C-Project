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
    public partial class StudentClasses : Form
    {
        ExamSystemContext Context = new ExamSystemContext();
        int StudentID = 1; // replace this with a static variable of CurrentUserID
        Form previousForm;
        public StudentClasses(Form previousForm)
        {
            InitializeComponent();
            GetData();
            this.previousForm = previousForm;
        }
        public void GetData()
        {
            var student = Context.Students.SingleOrDefault(std => std.Id == StudentID);
            dataGridView1.DataSource = Context.Classes
                .Include(Class => Class.Branch)
                .Where(Class => Class.Name.Contains(SearchTXT.Text.Trim()) && Class.Id == student.ClassId)
                .Select(Class => new { Class.Id, Class.Name, Class.Floor, Branch = Class.Branch.Name })
                .OrderBy(dept => dept.Branch)
                .ToList();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();

        }

        private void StudentClasses_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
