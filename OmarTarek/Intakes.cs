using C__Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project.OmarTarek
{
    public partial class Intakes : Form
    {
        Form previousForm;
        ExamSystemContext Context;
        Regex IntakeRegex = new Regex(@"^(?=.{3,50}$)[a-zA-Z0-9]+(?:[' -][a-zA-Z0-9]+)*$");
        public Intakes(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            Context = new ExamSystemContext();
            GetData();
            addBTN.Enabled = false;
            startTimeDP.MinDate = DateTime.Now.Date;
            startTimeDP.Value = startTimeDP.MinDate;
            startTimeDP.MaxDate = DateTime.Now.AddYears(4).AddMonths(9).Date;
            endTimeDP.MinDate = DateTime.Now.AddMonths(3).Date;
            endTimeDP.Value = endTimeDP.MinDate;
            endTimeDP.MaxDate = DateTime.Now.AddYears(5).Date;
        }
        public void GetData()
        {
            dataGridView1.DataSource =
                Context.Intakes
                .Where(intake => intake.Name.Contains(SearchTXT.Text.Trim()))
                .Select(intake => new
                {
                    intake.Id,
                    intake.Name,
                    intake.StartTime,
                    intake.EndTime
                })
                .OrderBy(track => track.Name)
                .ToList();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.TopLeftHeaderCell.Value = "Edit";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AutoResizeColumns();
        }

        private void Intakes_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }
        public void RegexTest()
        {
            bool nameVali = IntakeRegex.IsMatch(nameTXT.Text.Trim());

            if (nameVali)
            { addBTN.Enabled = true; updateBTN.Enabled = true; }
            else
            { addBTN.Enabled = false; updateBTN.Enabled = false; }

        }

        private void nameTXT_TextChanged(object sender, EventArgs e)
        {
            bool nameVali = IntakeRegex.IsMatch(nameTXT.Text.Trim());
            if (nameVali) { nameValiLBL.Visible = false; } else { nameValiLBL.Visible = true; }
            RegexTest();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            Intake intake = new Intake() { Name = nameTXT.Text.Trim(), StartTime = startTimeDP.Value.Date, EndTime = endTimeDP.Value.Date };
            Context.Add(intake);
            Context.SaveChanges();
            EndModification();
            GetData();
        }

        private void EndModification()
        {
            nameTXT.Text = idTXT.Text = "";
            nameValiLBL.Visible = false;
            startTimeDP.Value = DateTime.Now;
            addBTN.Visible = true;
            updateBTN.Visible = false;
            deleteBTN.Visible = false;
            exitModiBTN.Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                idTXT.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                nameTXT.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                startTimeDP.Value = (DateTime)dataGridView1[2, e.RowIndex].Value;
                endTimeDP.Value = (DateTime)dataGridView1[3, e.RowIndex].Value;

                addBTN.Visible = false;
                updateBTN.Visible = true;
                deleteBTN.Visible = true;
                exitModiBTN.Visible = true;
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            Intake intake = Context.Intakes.Where(intake => intake.Id == int.Parse(idTXT.Text)).SingleOrDefault();
            intake.Name = nameTXT.Text.Trim();
            intake.StartTime = startTimeDP.Value.Date;
            intake.EndTime = endTimeDP.Value.Date;
            Context.SaveChanges();
            EndModification();
            GetData();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            Intake intake = Context.Intakes.Where(intake => intake.Id == int.Parse(idTXT.Text)).SingleOrDefault();
            Context.Intakes.Remove(intake);
            Context.SaveChanges();
            EndModification();
            GetData();
        }

        private void exitModiBTN_Click(object sender, EventArgs e)
        {
            EndModification();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void startTimeDP_ValueChanged(object sender, EventArgs e)
        {
            endTimeDP.MinDate = startTimeDP.Value.Date.AddMonths(3);
            endTimeDP.Value = endTimeDP.MinDate;
        }
    }
}
