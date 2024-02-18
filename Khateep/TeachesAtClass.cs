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
using Microsoft.EntityFrameworkCore;

namespace C__Project.Khateep
{
    public partial class TeachesAtClass : Form
    {
        Form previousForm;
        ExamSystemContext Context = new ExamSystemContext();
        TeachesAt? TAExistUpdate;
        public TeachesAtClass(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            GetData();
        }
        public void GetData()
        {
            var TeachesAtList = Context.TeachesAts
                .Include(TA => TA.Class)
                .Include(TA => TA.Course)
                .Include(TA => TA.Instructor)
                .Where(TA => TA.Course.Name.Contains(SearchTXT.Text.Trim()))
                .Select(TA => new { TA.CourseId, TA.ClassId, TA.InstructorId, Course = TA.Course.Name, Class = TA.Class.Name, Instructor = TA.Instructor.Name })
                .ToList();

            dataGridView1.DataSource = TeachesAtList;
            dataGridView1.Columns["CourseId"].Visible = false;
            dataGridView1.Columns["ClassId"].Visible = false;
            dataGridView1.Columns["InstructorId"].Visible = false;

            var courses = Context.Courses.Select(course => new { ID = course.Id, Name = course.Name }).ToList();
            var classes = Context.Classes.Select(c => new { ID = c.Id, Name = c.Name }).ToList();
            var instructors = Context.Instructors.Select(c => new { ID = c.Id, Name = c.Name }).ToList();

            courseCB.DataSource = courses;
            courseCB.ValueMember = "ID";
            courseCB.DisplayMember = "Name";
            courseCB.SelectedIndex = 0;
            courseCB.DropDownStyle = ComboBoxStyle.DropDownList;

            classCB.DataSource = classes;
            classCB.ValueMember = "ID";
            classCB.DisplayMember = "Name";
            classCB.SelectedIndex = 0;
            classCB.DropDownStyle = ComboBoxStyle.DropDownList;

            instructorCB.DataSource = instructors;
            instructorCB.ValueMember = "ID";
            instructorCB.DisplayMember = "Name";
            instructorCB.SelectedIndex = -1;
            instructorCB.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();
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

        private void setNullBTN_Click(object sender, EventArgs e)
        {
            instructorCB.SelectedIndex = -1;
        }
        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
        private void EndModification()
        {
            courseCB.SelectedIndex = classCB.SelectedIndex = 0;
            instructorCB.SelectedIndex = -1;
            TAExistUpdate = null;
            addBTN.Visible = true;
            updateBTN.Visible = false;
            deleteBTN.Visible = false;
            exitModiBTN.Visible = false;
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                TeachesAt teaches = new TeachesAt() { ClassId = (int)classCB.SelectedValue, CourseId = (int)courseCB.SelectedValue, InstructorId = instructorCB.SelectedIndex == -1 ? null : (int)instructorCB.SelectedValue };

                var itExists = Context.TeachesAts
                    .Include(TA => TA.Class)
                    .Include(TA => TA.Course)
                    .Include(TA => TA.Instructor)
                    .SingleOrDefault(TA => TA.CourseId == teaches.CourseId && TA.ClassId == teaches.ClassId);
                if (itExists != null)
                {
                    if (itExists.InstructorId == null) { throw new Exception("A Course cannot be taught in a class by more than one instructor,\neven if it the instructor isn't assigned , update the entry instead. "); }
                    else
                    {
                        throw new Exception($"this Course ' {itExists.Course.Name} ' is being taught already in Class ' {itExists.Class.Name} ' by Instructor ' {itExists.Instructor.Name} '\nA Course cannot be taught in a class by more than one instructor");
                    }
                }

                Context.TeachesAts.Add(teaches);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"{ex.InnerException}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                GetData();
                EndModification();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                courseCB.SelectedValue = dataGridView1[0, e.RowIndex].Value;
                classCB.SelectedValue = dataGridView1[1, e.RowIndex].Value;
                _ = dataGridView1[2, e.RowIndex].Value == null ? instructorCB.SelectedIndex = -1 : instructorCB.SelectedValue = dataGridView1[2, e.RowIndex].Value;


                TAExistUpdate = Context.TeachesAts
                    .SingleOrDefault(TA => TA.CourseId == (int)courseCB.SelectedValue && TA.ClassId == (int)classCB.SelectedValue);

                addBTN.Visible = false;
                updateBTN.Visible = true;
                deleteBTN.Visible = true;
                exitModiBTN.Visible = true;
            }
        }

        private void exitModiBTN_Click(object sender, EventArgs e)
        {
            EndModification();
            
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            var itExists = Context.TeachesAts
                    .SingleOrDefault(TA => TA.CourseId == (int)courseCB.SelectedValue && TA.ClassId == (int)classCB.SelectedValue);

            Context.TeachesAts.Remove(itExists);
            Context.SaveChanges();
            GetData();
            EndModification();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                var teaches = Context.TeachesAts
                    .SingleOrDefault(TA => TA.CourseId == (int)courseCB.SelectedValue && TA.ClassId == (int)classCB.SelectedValue);

                if (teaches != null && teaches != TAExistUpdate)
                {
                    if (teaches.InstructorId == null) { throw new Exception("A Course cannot be taught in a class by more than one instructor,\neven if it the instructor isn't assigned , update the entry instead. "); }
                    else
                    {
                        throw new Exception($"this Course ' {teaches.Course.Name} ' is being taught already in Class ' {teaches.Class.Name} ' by Instructor ' {teaches.Instructor.Name} '\nA Course cannot be taught in a class by more than one instructor");
                    }
                }

                TAExistUpdate.CourseId = (int)courseCB.SelectedValue;
                TAExistUpdate.ClassId = (int)classCB.SelectedValue;
                TAExistUpdate.InstructorId = instructorCB.SelectedIndex != -1 ? (int)instructorCB.SelectedValue : null;

                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"{ex.InnerException}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                GetData();
                EndModification();
            }
        }
    }
}
