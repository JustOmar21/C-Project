using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C__Project.Models;

namespace C__Project.Khateep
{
    public partial class TeachesAt : Form
    {
        Form previousForm;
        ExamSystemContext Context;
        public TeachesAt(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            Context = new ExamSystemContext();
        }

        private void TeachesAt_Load(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void TeachesAt_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();

        }
    }
}
