using C__Project.Models;
using C__Project.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Timer = System.Windows.Forms.Timer;

namespace C__Project.OmarTarek.Student_Forms
{
    public partial class StudentAnswering : Form
    {
        int questionNumber = 0;
        int studentID = 1; // replace this with a static variable of CurrentUserID
        Form previousForm;
        Timer timer;
        TimeSpan timeSpan;
        TimeSpan UnoSecondo;
        StudentExam studentExam;
        ExamSystemContext Context = new ExamSystemContext();
        List<ExamQuestionDetails> Questions;
        bool stopRadioEvent = false;
        internal StudentAnswering(Form previousForm, StudentExam studentExam , string name = "Exam Name")
        {
            InitializeComponent();
            this.studentExam = studentExam;
            this.previousForm = previousForm;
            this.Text = name;
            choice1.Text = "1";
            choice2.Text = "2";
            choice3.Text = "3";
            choice4.Text = "4";
            timerProcess();
            retrieveExamQuestions();
            setQuestions();

        }
        private void setQuestions()
        {
            questionNumber %= 10;
            questionLBL.Text = $"Question {questionNumber + 1}";
            questionBodyTXT.Text = Questions[questionNumber].question.Body;

            // Getting the Answer that the student already provided
            int questionID = Questions[questionNumber].question.Id;
            int ExamID = studentExam.ExamId;
            var singleExamQuestion = Context.ExamQuestions.FirstOrDefault(EQ => EQ.ExamId == ExamID && EQ.QuestionId == questionID);
            var studentAnswer = Context.StudentAnswers
                .SingleOrDefault(stdAnswer => stdAnswer.StudentExamId == studentExam.Id && stdAnswer.ExamQuestionId == singleExamQuestion.Id);

            var choices = Questions[questionNumber].question.Choices.ToList();
            var type = Questions[questionNumber].question.Type;
            choice1TXT.Text = choices[0].Choice;
            choice2TXT.Text = choices[1].Choice;
            choice3TXT.Text = choices[2].Choice;
            choice4TXT.Text = choices[3].Choice;
            stopRadioEvent = true;
            if(studentAnswer != null)
            {
                if(studentAnswer.Answer == 1)
                {
                    choice1.Checked = true;
                    choice2.Checked = choice3.Checked = choice4.Checked = false;
                }
                else if(studentAnswer.Answer == 2)
                {
                    choice2.Checked = true;
                    choice1.Checked = choice3.Checked = choice4.Checked = false;
                }
                else if(studentAnswer.Answer == 3)
                {
                    choice3.Checked = true;
                    choice2.Checked = choice1.Checked = choice4.Checked = false;
                }
                else if(studentAnswer.Answer == 4)
                {
                    choice4.Checked = true;
                    choice2.Checked = choice3.Checked = choice1.Checked = false;
                }
            }
            else
            {
                choice1.Checked = choice2.Checked = choice3.Checked = choice4.Checked = false;
            }
            stopRadioEvent = false;
            if (type == "TF")
            {
                choice3.Visible = false;
                choice4.Visible = false;
                choice3TXT.Visible = false;
                choice4TXT.Visible = false;
            }
            else
            {
                choice3.Visible = true;
                choice4.Visible = true;
                choice3TXT.Visible = true;
                choice4TXT.Visible = true;
            }
        }
        private void retrieveExamQuestions()
        {
            int ExamID = studentExam.ExamId;

            Questions = Context.ExamQuestions
                .Where(exam => exam.ExamId == ExamID)
                .Include(exam => exam.Question)
                .ThenInclude(exam => exam.Choices)
                .Select(question => new ExamQuestionDetails { question = question.Question, degree = question.Degree })
                .ToList();
        }

        private void timerProcess()
        {
            UnoSecondo = new TimeSpan(0, 0, 0, 1);
            timeSpan = studentExam.Exam.EndTime - DateTime.Now;
            timeLBL.Text = timeSpan.ToString(@"hh\:mm\:ss");
            timer = new Timer();
            timer.Tick += timeChange;
            timer.Interval = 1000;
            timer.Start();
        }

        private void timeChange(object? sender, EventArgs e)
        {
            if (timeSpan > TimeSpan.Zero)
            {
                timeSpan = timeSpan.Subtract(UnoSecondo);
                timeLBL.Text = timeSpan.ToString(@"hh\:mm\:ss");
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Times Up !", "The Exam is Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            if (timeSpan < new TimeSpan(0, 10, 0))
            {
                SystemSounds.Exclamation.Play();
                timeLBL.ForeColor = Color.Red;
            }
        }

        private void StudentAnswering_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Dispose();
            previousForm.Show();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            questionLBL.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void exitExamBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void choice1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (!stopRadioEvent)
            {
                int questionID = Questions[questionNumber].question.Id;
                int ExamID = studentExam.ExamId;
                var singleStudentExam = Context.StudentExams.SingleOrDefault(SE => SE.ExamId == ExamID && SE.StudentId == studentID);
                var singleExamQuestion = Context.ExamQuestions.FirstOrDefault(EQ => EQ.ExamId == ExamID && EQ.QuestionId == questionID);
                var studentAnswer = Context.StudentAnswers
                    .SingleOrDefault(stdAnswer => stdAnswer.StudentExamId == studentExam.Id && stdAnswer.ExamQuestionId == singleExamQuestion.Id);

                if (choice1.Checked)
                {
                    if (Questions[questionNumber].question.CorrectChoiceNumber == 1)
                    {
                        singleStudentExam.Degree += Questions[questionNumber].degree;
                    }
                }
                else if (!choice1.Checked)
                {
                    if (Questions[questionNumber].question.CorrectChoiceNumber == 1)
                    {
                        singleStudentExam.Degree -= Questions[questionNumber].degree;
                    }
                }
                if (studentAnswer != null)
                {
                    studentAnswer.Answer = 1;
                    Context.StudentAnswers.Update(studentAnswer);
                }
                else if (studentAnswer == null)
                {
                    StudentAnswer Answer = new StudentAnswer() { ExamQuestionId = singleExamQuestion.Id, StudentExamId = studentExam.Id, Answer = 1 };
                    Context.StudentAnswers.Add(Answer);
                }
                Context.SaveChanges();
            }

            
        }

        private void choice2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (!stopRadioEvent)
            {
                int questionID = Questions[questionNumber].question.Id;
                int ExamID = studentExam.ExamId;
                var singleStudentExam = Context.StudentExams.SingleOrDefault(SE => SE.ExamId == ExamID && SE.StudentId == studentID);
                var singleExamQuestion = Context.ExamQuestions.FirstOrDefault(EQ => EQ.ExamId == ExamID && EQ.QuestionId == questionID);
                var studentAnswer = Context.StudentAnswers
                    .SingleOrDefault(stdAnswer => stdAnswer.StudentExamId == studentExam.Id && stdAnswer.ExamQuestionId == singleExamQuestion.Id);

                if (choice2.Checked)
                {
                    if (Questions[questionNumber].question.CorrectChoiceNumber == 2)
                    {
                        singleStudentExam.Degree += Questions[questionNumber].degree;
                    }
                }
                else if (!choice2.Checked)
                {
                    if (Questions[questionNumber].question.CorrectChoiceNumber == 2)
                    {
                        singleStudentExam.Degree -= Questions[questionNumber].degree;
                    }
                }
                if (studentAnswer != null)
                {
                    studentAnswer.Answer = 2;
                    Context.StudentAnswers.Update(studentAnswer);
                }
                else if (studentAnswer == null)
                {
                    StudentAnswer Answer = new StudentAnswer() { ExamQuestionId = singleExamQuestion.Id, StudentExamId = studentExam.Id, Answer = 2 };
                    Context.StudentAnswers.Add(Answer);
                }
                Context.SaveChanges();
            }
            
        }

        private void choice3_CheckedChanged(object sender, EventArgs e)
        {
            if (!stopRadioEvent)
            {
                int questionID = Questions[questionNumber].question.Id;
                int ExamID = studentExam.ExamId;
                var singleStudentExam = Context.StudentExams.SingleOrDefault(SE => SE.ExamId == ExamID && SE.StudentId == studentID);
                var singleExamQuestion = Context.ExamQuestions.FirstOrDefault(EQ => EQ.ExamId == ExamID && EQ.QuestionId == questionID);
                var studentAnswer = Context.StudentAnswers
                    .SingleOrDefault(stdAnswer => stdAnswer.StudentExamId == studentExam.Id && stdAnswer.ExamQuestionId == singleExamQuestion.Id);

                if (choice3.Checked)
                {
                    if (Questions[questionNumber].question.CorrectChoiceNumber == 3)
                    {
                        singleStudentExam.Degree += Questions[questionNumber].degree;
                    }
                }
                else if (!choice3.Checked)
                {
                    if (Questions[questionNumber].question.CorrectChoiceNumber == 3)
                    {
                        singleStudentExam.Degree -= Questions[questionNumber].degree;
                    }
                }
                if (studentAnswer != null)
                {
                    studentAnswer.Answer = 3;
                    Context.StudentAnswers.Update(studentAnswer);
                }
                else if (studentAnswer == null)
                {
                    StudentAnswer Answer = new StudentAnswer() { ExamQuestionId = singleExamQuestion.Id, StudentExamId = studentExam.Id, Answer = 3 };
                    Context.StudentAnswers.Add(Answer);
                }
                Context.SaveChanges();
            }
            
        }

        private void choice4_CheckedChanged(object sender, EventArgs e)
        {
            if(!stopRadioEvent)
            {
                int questionID = Questions[questionNumber].question.Id;
                int ExamID = studentExam.ExamId;
                var singleStudentExam = Context.StudentExams.SingleOrDefault(SE => SE.ExamId == ExamID && SE.StudentId == studentID);
                var singleExamQuestion = Context.ExamQuestions.FirstOrDefault(EQ => EQ.ExamId == ExamID && EQ.QuestionId == questionID);
                var studentAnswer = Context.StudentAnswers
                    .SingleOrDefault(stdAnswer => stdAnswer.StudentExamId == studentExam.Id && stdAnswer.ExamQuestionId == singleExamQuestion.Id);

                if (choice4.Checked)
                {
                    if (Questions[questionNumber].question.CorrectChoiceNumber == 4)
                    {
                        singleStudentExam.Degree += Questions[questionNumber].degree;
                    }
                }
                else if (!choice4.Checked)
                {
                    if (Questions[questionNumber].question.CorrectChoiceNumber == 4)
                    {
                        singleStudentExam.Degree -= Questions[questionNumber].degree;
                    }
                }
                if (studentAnswer != null)
                {
                    studentAnswer.Answer = 4;
                    Context.StudentAnswers.Update(studentAnswer);
                }
                else if (studentAnswer == null)
                {
                    StudentAnswer Answer = new StudentAnswer() { ExamQuestionId = singleExamQuestion.Id, StudentExamId = studentExam.Id, Answer = 4 };
                    Context.StudentAnswers.Add(Answer);
                }
                Context.SaveChanges();
            }
            
        }

        private void nextQuestionBTN_Click(object sender, EventArgs e)
        {
            questionNumber++;
            setQuestions();
        }

        private void prevQuestionButton_Click(object sender, EventArgs e)
        {
            if (questionNumber == 0)
            {
                questionNumber = 9;
            }
            else
            {
                questionNumber--;
            }
            setQuestions();
        }

        private void choice1TXT_MouseDown(object sender, MouseEventArgs e)
        {
            choice1.Checked = true;
        }

        private void choice2TXT_MouseDown(object sender, MouseEventArgs e)
        {
            choice2.Checked = true;
        }

        private void choice3TXT_MouseDown(object sender, MouseEventArgs e)
        {
            choice3.Checked = true;
        }

        private void choice4TXT_MouseDown(object sender, MouseEventArgs e)
        {
            choice4.Checked = true;
        }
    }
}
