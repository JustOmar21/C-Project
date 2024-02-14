using C__Project.FaresAwad;
using C__Project.Khateep;
using C__Project.Models;
using C__Project.OmarTarek;
using C__Project.OmarTarek.Student_Forms;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace C__Project
{
    public partial class Form1 : Form
    {
        ExamSystemContext Context;
        public Form1()
        {
            InitializeComponent();
            Context = new ExamSystemContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Branches b = new Branches(this);
            this.Hide();
            b.Show();

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Intakes intake = new Intakes(this);
            this.Hide();
            intake.Show();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            Students student = new Students(this);
            this.Hide();
            student.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentExams student = new StudentExams(this);
            this.Hide();
            student.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StudentProfile studentProfile = new StudentProfile(this);
            this.Hide();
            studentProfile.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StudentClasses studentClasses = new StudentClasses(this);
            this.Hide();
            studentClasses.Show();
        }

        private void coursesBTN_Click(object sender, EventArgs e)
        {
            Courses course = new Courses(this);
            this.Hide();
            course.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void examsBTN_Click(object sender, EventArgs e)
        {
            Exams exam = new Exams(this);
            this.Hide();
            exam.Show();

        }
    }
}
