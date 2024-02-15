﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C__Project.Models;
using C__Project.OmarTarek;
using C__Project.OmarTarek.Student_Forms;
using Microsoft.EntityFrameworkCore;

namespace C__Project.Khateep
{
    public partial class StudentsToExam : Form
    {
        Form previousForm;
        ExamSystemContext Context;
        public StudentsToExam(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            Context = new ExamSystemContext();
            GetData();
            degreeNum.Minimum = 0;
            degreeNum.Maximum = 100;
            degreeNum.Value = 0;
            degreeNum.ReadOnly = true;
        }
        public void GetData()
        {
            var studentExam = Context.StudentExams
                .Include(studentExam => studentExam.Student) //id name
                .Include(studentExam => studentExam.Exam) // id name
/*                .ThenInclude(exam => exam.Course) // name
*/                .Select(studentExam => new
                  {
                      studentExam.Id,
                      studentExam.StudentId,
                      studentExam.ExamId,
                      Exam = studentExam.Exam.Name,
                      Student = studentExam.Student.Name,
                      studentExam.Degree
                  })
                .OrderByDescending(studentExam => studentExam.ExamId)
                .ToList();

            dataGridView1.DataSource = studentExam;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["StudentId"].Visible = false;
            dataGridView1.Columns["ExamId"].Visible = false;
            var exams = Context.Exams.Select(exam => new { ID = exam.Id, exam.Name }).ToList();
            exmCB.DataSource = exams;
            exmCB.DisplayMember = "Name";
            exmCB.SelectedIndex = 0;
            exmCB.ValueMember = "ID";
            exmCB.DropDownStyle = ComboBoxStyle.DropDownList;
            var courseID = Context.Exams
                .Where(exam => exam.Id == (int?)exmCB.SelectedValue)
                .Select(exam => exam.Course.Id)
                .SingleOrDefault();

            var students = Context.Students
                .Include(std => std.Class)
                .ThenInclude(cls => cls.TeachesClass)
                .Where(std => std.Class.TeachesClass.Any(cls => cls.CourseId == courseID))
                .Select(std => new { ID = std.Id, std.Name })
                .ToList();
            stdCB.DataSource = students;
            stdCB.DisplayMember = "Name";
            stdCB.SelectedIndex = 0;
            stdCB.ValueMember = "ID";
            stdCB.DropDownStyle = ComboBoxStyle.DropDownList;


            dataGridView1.TopLeftHeaderCell.Value = "Edit";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
        }
        private void EndModification()
        {
            idTXT.Text = "";
            stdCB.SelectedIndex = 0;
            exmCB.SelectedIndex = 0;
            addBTN.Visible = true;
            updateBTN.Visible = false;
            deleteBTN.Visible = false;
            exitModiBTN.Visible = false;


        }
        private void StudentsToExam_Load(object sender, EventArgs e)
        {

        }

        private void StudentExamCourse()
        {
            var courseID = Context.Exams
                .Where(exam => exam.Id == (int?)exmCB.SelectedValue)
                .Select(exam => exam.Course.Id)
                .SingleOrDefault();

            var students = Context.Students
                .Include(std => std.Class)
                .ThenInclude(cls => cls.TeachesClass)
                .Where(std => std.Class.TeachesClass.Any(cls => cls.CourseId == courseID))
                .Select(std => new { ID = std.Id, std.Name })
                .ToList();

            stdCB.DataSource = students;
        }
        private void StudentsToExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void degreeTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            EndModification();
            GetData();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            EndModification();
            GetData();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            EndModification();
            GetData();
        }

        private void exitModiBTN_Click(object sender, EventArgs e)
        {
            EndModification();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                idTXT.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                degreeNum.Value = (int)dataGridView1[1, e.RowIndex].Value;

                stdCB.SelectedValue = (int)dataGridView1[2, e.RowIndex].Value;
                exmCB.SelectedValue = (int)dataGridView1[3, e.RowIndex].Value;
                stdCB.SelectedValue = (int)dataGridView1[4, e.RowIndex].Value;



                addBTN.Visible = false;
                updateBTN.Visible = true;
                deleteBTN.Visible = true;
                exitModiBTN.Visible = true;
            }
        }

        private void exmCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentExamCourse();
        }
    }
}
