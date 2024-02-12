using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class ExamSystemContext : DbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Intake> Intakes { get; set; }
        public DbSet<Login> Logins { get; set; }

        public DbSet<Manager> Managers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionChoices> QuestionChoices { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAnswer> StudentAnswers { get; set; }
        public DbSet<StudentExam> StudentExams { get; set; }
        public DbSet<TeachesAt> TeachesAts { get; set; }
        public DbSet<Track> Tracks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TBN Exam System;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>().HasKey(Login => new { Login.Email, Login.Type });
            modelBuilder.Entity<Login>().ToTable(Login => Login.HasCheckConstraint("CK_Log_Type", "[Type] = 'Admin' OR [Type] = 'Student' OR [Type] = 'Manager' OR [Type] = 'Instructor'"));
            modelBuilder.Entity<Login>().HasData(
                new Login() { Email="Admin@gmail.com" , Password="123456789sS" , Type="Admin"},
                new Login() { Email = "tarekes68@gmail.com" , Password = "123456789sS" , Type="Student"}
                );

            modelBuilder.Entity<Question>().ToTable(Q => Q.HasCheckConstraint("CK_Q_CCN", "CorrectChoiceNumber >= 1 AND CorrectChoiceNumber <= 4 "));
            modelBuilder.Entity<Question>().ToTable(Q => Q.HasCheckConstraint("CK_Q_Type", "[Type] = 'MCQ' OR [Type] = 'TF'"));

            modelBuilder.Entity<QuestionChoices>().HasKey(QC => new { QC.QuestionId, QC.ChoiceNumber });
            modelBuilder.Entity<QuestionChoices>().ToTable(QC => QC.HasCheckConstraint("CK_QC_CN", "ChoiceNumber >= 1 AND ChoiceNumber <= 4 "));

            modelBuilder.Entity<StudentAnswer>().HasKey(SA => new { SA.StudentExamId, SA.ExamQuestionId });

            modelBuilder.Entity<StudentExam>().HasIndex(SE => new { SE.StudentId, SE.ExamId }).IsUnique();
            modelBuilder.Entity<StudentExam>().ToTable(SE => SE.HasCheckConstraint("CK_SE_Degree", "Degree >= 0"));

            modelBuilder.Entity<ExamQuestion>().ToTable(EQ => EQ.HasCheckConstraint("CK_EQ_Degree", "Degree > 0"));
            modelBuilder.Entity<ExamQuestion>().HasIndex(EQ => new { EQ.QuestionId, EQ.ExamId }).IsUnique();

            modelBuilder.Entity<TeachesAt>().HasKey(TA => new { TA.CourseId, TA.ClassId });

            modelBuilder.Entity<Exam>().ToTable(EX => EX.HasCheckConstraint("CK_EX_StartEndTime", "StartTime < EndTime"));
            modelBuilder.Entity<Exam>().ToTable(EX => EX.HasCheckConstraint("CK_EX_StartTime", "DATEDIFF(YEAR, GetDate() , StartTime) <= 10"));
            modelBuilder.Entity<Exam>().ToTable(EX => EX.HasCheckConstraint("CK_EX_StartEndTimeHourDiffBefore", "DATEDIFF(HOUR, StartTime , EndTime) >= 1 "));
            modelBuilder.Entity<Exam>().ToTable(EX => EX.HasCheckConstraint("CK_EX_StartEndTimeHourDiffAfter", "DATEDIFF(HOUR, StartTime , EndTime) <= 4 "));
            modelBuilder.Entity<Exam>().ToTable(EX => EX.HasCheckConstraint("CK_EX_StartEndTimeDayDiff", "DATEDIFF(DAY, StartTime , EndTime) = 0 "));

            modelBuilder.Entity<Instructor>().ToTable(Ins => Ins.HasCheckConstraint("CK_Ins_Salary", "Salary >= 4000"));
            modelBuilder.Entity<Instructor>().HasIndex(Ins => Ins.Email).IsUnique();
            modelBuilder.Entity<Instructor>().ToTable(Ins => Ins.HasCheckConstraint("CK_Ins_DOB", "DATEDIFF(YEAR, DOB , GetDate()) >= 21"));

            modelBuilder.Entity<Manager>().ToTable(MGR => MGR.HasCheckConstraint("CK_Mgr_Salary", "Salary >= 4000"));
            modelBuilder.Entity<Manager>().HasIndex(MGR => MGR.Email).IsUnique();
            modelBuilder.Entity<Manager>().ToTable(MGR => MGR.HasCheckConstraint("CK_MGR_DOB", "DATEDIFF(YEAR, DOB , GetDate()) >= 21"));

            modelBuilder.Entity<Student>().HasIndex(Std => Std.Email).IsUnique();
            modelBuilder.Entity<Student>().ToTable(Std => Std.HasCheckConstraint("CK_Std_DOB", "DATEDIFF(YEAR, DOB , GetDate()) >= 15"));

            modelBuilder.Entity<Course>().ToTable(Crs => Crs.HasCheckConstraint("CK_Crs_MinMax", "MaxDegree > MinDegree"));
            modelBuilder.Entity<Course>().ToTable(Crs => Crs.HasCheckConstraint("CK_Crs_MinDeg", "MinDegree > 0"));

            modelBuilder.Entity<Intake>().ToTable(Int => Int.HasCheckConstraint("CK_Int_StartEndTime", "StartTime < EndTime"));
            modelBuilder.Entity<Intake>().ToTable(Int => Int.HasCheckConstraint("CK_Int_StartTime", "DATEDIFF(YEAR, GetDate() , StartTime) <= 5"));
            modelBuilder.Entity<Intake>().ToTable(Int => Int.HasCheckConstraint("CK_Int_StartEndTimeMonths", "DATEDIFF(MONTH, StartTime , EndTime) >= 3"));

            // Data Seeding

            modelBuilder.Entity<Branch>().HasData(
                new Branch() { Id = 1 , Name ="ITI Menofia" , Location ="Menofia"},
                new Branch() { Id = 2 , Name ="ITI Beni Suef" , Location ="Beni Suef"},
                new Branch() { Id = 3 , Name ="ITI Btengan" , Location ="Btengan"}
                );

            modelBuilder.Entity<Department>().HasData(
                new Department() { Id = 1 , Name = "Internet of Things" , BranchId = 1 },
                new Department() { Id = 2 , Name = "Strike Back" , BranchId = 2 },
                new Department() { Id = 3 , Name = "Watermelon" , BranchId = 3 },
                new Department() { Id = 4 , Name = "Web Development" , BranchId = 1 },
                new Department() { Id = 5 , Name = "Bad Sugarcane Juice" , BranchId = 2 },
                new Department() { Id = 6 , Name = "Banana" , BranchId = 3 },
                new Department() { Id = 7 , Name = "Good Sugarcane Juice" , BranchId = 1 },
                new Department() { Id = 8 , Name = "Headphones" , BranchId = 2 },
                new Department() { Id = 9 , Name = "Apples" , BranchId = 3 }
                );

            modelBuilder.Entity<Track>().HasData(
                new Track() { Id = 1 , Name = "DotNet Core" , Description ="No Way Jose" , DepartmentId = 5},
                new Track() { Id = 2 , Name = "Alexandria IOT" , Description ="Ahmed is there" , DepartmentId = 7},
                new Track() { Id = 3 , Name = "Tsunami" , Description ="Bringing a wave of freedom" , DepartmentId = 1}
                );

            modelBuilder.Entity<Intake>().HasData(
                new Intake() { Id = 1 , Name = "Intake 42" , StartTime = DateTime.Now.Date , EndTime = DateTime.Now.AddYears(1).Date },
                new Intake() { Id = 2 , Name = "Intake 43" , StartTime = DateTime.Now.Date , EndTime = DateTime.Now.AddMonths(4).Date },
                new Intake() { Id = 3 , Name = "Intake 44" , StartTime = DateTime.Now.AddYears(1).Date , EndTime = DateTime.Now.AddYears(2).Date }

                );

            modelBuilder.Entity<Class>().HasData(
                new Class() { Id = 1 , Name ="MN Class 1" , Floor = 1 , BranchId = 1 },
                new Class() { Id = 2 , Name ="MN Class 2" , Floor = 2 , BranchId = 1 },
                new Class() { Id = 3 , Name ="MN Class 3" , Floor = 3 , BranchId = 1 },

                new Class() { Id = 4, Name = "BS Class 1", Floor = 1, BranchId = 2 },
                new Class() { Id = 5, Name = "BS Class 2", Floor = 2, BranchId = 2 },
                new Class() { Id = 6, Name = "BS Class 3", Floor = 3, BranchId = 2 },

                new Class() { Id = 7, Name = "BT Class 1", Floor = 1, BranchId = 3 },
                new Class() { Id = 8, Name = "BT Class 2", Floor = 2, BranchId = 3 },
                new Class() { Id = 9, Name = "BT Class 3", Floor = 3, BranchId = 3 }
                );


            modelBuilder.Entity<Course>().HasData(
                new Course() { Id = 1 , Name = "C#" , Description ="Whatever" , MaxDegree = 100 , MinDegree = 50},
                new Course() { Id = 2 , Name = "SQL" , Description ="Whatever" , MaxDegree = 100 , MinDegree = 70},
                new Course() { Id = 3 , Name = "ASP DOTNET" , Description ="Whatever" , MaxDegree = 100 , MinDegree = 10}
                );

            modelBuilder.Entity<Question>().HasData(
                new Question() { Id = 1, Body = "Correct Choice is 1", Type = "MCQ", CorrectChoiceNumber = 1, CourseId = 1, InstructorId = null },
                new Question() { Id = 2, Body = "Correct Choice is 2", Type = "TF", CorrectChoiceNumber = 2, CourseId = 1, InstructorId = null },
                new Question() { Id = 3, Body = "Correct Choice is 3", Type = "MCQ", CorrectChoiceNumber = 3, CourseId = 1, InstructorId = null },
                new Question() { Id = 4, Body = "Correct Choice is 4", Type = "MCQ", CorrectChoiceNumber = 4, CourseId = 1, InstructorId = null },
                new Question() { Id = 5, Body = "Correct Choice is 1", Type = "TF", CorrectChoiceNumber = 1, CourseId = 1, InstructorId = null },
                new Question() { Id = 6, Body = "Correct Choice is 3", Type = "MCQ", CorrectChoiceNumber = 3, CourseId = 1, InstructorId = null },
                new Question() { Id = 7, Body = "Correct Choice is 2", Type = "TF", CorrectChoiceNumber = 2, CourseId = 1, InstructorId = null },
                new Question() { Id = 8, Body = "Correct Choice is 1", Type = "TF", CorrectChoiceNumber = 1, CourseId = 1, InstructorId = null },
                new Question() { Id = 9, Body = "Correct Choice is 4", Type = "MCQ", CorrectChoiceNumber = 4, CourseId = 1, InstructorId = null },
                new Question() { Id = 10, Body = "Correct Choice is 3", Type = "MCQ", CorrectChoiceNumber = 3, CourseId = 1, InstructorId = null }
                );
            modelBuilder.Entity<QuestionChoices>().HasData(
                new QuestionChoices() { QuestionId = 1 , ChoiceNumber = 1 , Choice = "Choice 1"},
                new QuestionChoices() { QuestionId = 1 , ChoiceNumber = 2 , Choice = "Choice 2"},
                new QuestionChoices() { QuestionId = 1 , ChoiceNumber = 3 , Choice = "Choice 3"},
                new QuestionChoices() { QuestionId = 1 , ChoiceNumber = 4 , Choice = "Choice 4"},

                new QuestionChoices() { QuestionId = 2, ChoiceNumber = 1, Choice = "True" },
                new QuestionChoices() { QuestionId = 2, ChoiceNumber = 2, Choice = "False" },
                new QuestionChoices() { QuestionId = 2, ChoiceNumber = 3, Choice = null },
                new QuestionChoices() { QuestionId = 2, ChoiceNumber = 4, Choice = null },

                new QuestionChoices() { QuestionId = 3, ChoiceNumber = 1, Choice = "Choice 1" },
                new QuestionChoices() { QuestionId = 3, ChoiceNumber = 2, Choice = "Choice 2" },
                new QuestionChoices() { QuestionId = 3, ChoiceNumber = 3, Choice = "Choice 3" },
                new QuestionChoices() { QuestionId = 3, ChoiceNumber = 4, Choice = "Choice 4" },

                new QuestionChoices() { QuestionId = 4, ChoiceNumber = 1, Choice = "Choice 1" },
                new QuestionChoices() { QuestionId = 4, ChoiceNumber = 2, Choice = "Choice 2" },
                new QuestionChoices() { QuestionId = 4, ChoiceNumber = 3, Choice = "Choice 3" },
                new QuestionChoices() { QuestionId = 4, ChoiceNumber = 4, Choice = "Choice 4" },

                new QuestionChoices() { QuestionId = 5, ChoiceNumber = 1, Choice = "True" },
                new QuestionChoices() { QuestionId = 5, ChoiceNumber = 2, Choice = "False" },
                new QuestionChoices() { QuestionId = 5, ChoiceNumber = 3, Choice = null },
                new QuestionChoices() { QuestionId = 5, ChoiceNumber = 4, Choice = null },

                new QuestionChoices() { QuestionId = 6, ChoiceNumber = 1, Choice = "Choice 1" },
                new QuestionChoices() { QuestionId = 6, ChoiceNumber = 2, Choice = "Choice 2" },
                new QuestionChoices() { QuestionId = 6, ChoiceNumber = 3, Choice = "Choice 3" },
                new QuestionChoices() { QuestionId = 6, ChoiceNumber = 4, Choice = "Choice 4" },

                new QuestionChoices() { QuestionId = 7, ChoiceNumber = 1, Choice = "True" },
                new QuestionChoices() { QuestionId = 7, ChoiceNumber = 2, Choice = "False" },
                new QuestionChoices() { QuestionId = 7, ChoiceNumber = 3, Choice = null },
                new QuestionChoices() { QuestionId = 7, ChoiceNumber = 4, Choice = null },

                new QuestionChoices() { QuestionId = 8, ChoiceNumber = 1, Choice = "True" },
                new QuestionChoices() { QuestionId = 8, ChoiceNumber = 2, Choice = "False" },
                new QuestionChoices() { QuestionId = 8, ChoiceNumber = 3, Choice = null },
                new QuestionChoices() { QuestionId = 8, ChoiceNumber = 4, Choice = null },

                new QuestionChoices() { QuestionId = 9, ChoiceNumber = 1, Choice = "Choice 1" },
                new QuestionChoices() { QuestionId = 9, ChoiceNumber = 2, Choice = "Choice 2" },
                new QuestionChoices() { QuestionId = 9, ChoiceNumber = 3, Choice = "Choice 3" },
                new QuestionChoices() { QuestionId = 9, ChoiceNumber = 4, Choice = "Choice 4" },

                new QuestionChoices() { QuestionId = 10, ChoiceNumber = 1, Choice = "Choice 1" },
                new QuestionChoices() { QuestionId = 10, ChoiceNumber = 2, Choice = "Choice 2" },
                new QuestionChoices() { QuestionId = 10, ChoiceNumber = 3, Choice = "Choice 3" },
                new QuestionChoices() { QuestionId = 10, ChoiceNumber = 4, Choice = "Choice 4" }
                );

            modelBuilder.Entity<Exam>().HasData(
                new Exam() { Id = 1 , Name = "Exam 1" , StartTime = DateTime.Parse("13/2/2024 15:00:00"), EndTime = DateTime.Parse("13/2/2024 18:00:00"), InstructorId = null , CourseId = 1 },
                new Exam() { Id = 2 , Name = "Exam 2" , StartTime = DateTime.Parse("13/12/2024 15:00:00"), EndTime = DateTime.Parse("13/12/2024 18:00:00"), InstructorId = null , CourseId = 1 }
                );

            modelBuilder.Entity<ExamQuestion>().HasData(
                new ExamQuestion() { Id = 1 , ExamId = 1 , QuestionId = 1 , Degree = 10},
                new ExamQuestion() { Id = 2 , ExamId = 1 , QuestionId = 2 , Degree = 10},
                new ExamQuestion() { Id = 3 , ExamId = 1 , QuestionId = 3 , Degree = 10},
                new ExamQuestion() { Id = 4 , ExamId = 1 , QuestionId = 4 , Degree = 10},
                new ExamQuestion() { Id = 5 , ExamId = 1 , QuestionId = 5 , Degree = 10},
                new ExamQuestion() { Id = 6 , ExamId = 1 , QuestionId = 6 , Degree = 10},
                new ExamQuestion() { Id = 7 , ExamId = 1 , QuestionId = 7 , Degree = 10},
                new ExamQuestion() { Id = 8 , ExamId = 1 , QuestionId = 8 , Degree = 10},
                new ExamQuestion() { Id = 9 , ExamId = 1 , QuestionId = 9 , Degree = 10},
                new ExamQuestion() { Id = 10 , ExamId = 1 , QuestionId = 10 , Degree = 10}
                );

            modelBuilder.Entity<Student>().HasData(
                new Student() { Id = 1 , Name ="Omar Tarek" , Email = "tarekes68@gmail.com" , DOB = DateTime.Parse("12/6/2001") , IntakeId = 2 , TrackId = 2 ,ClassId = 3}
                );

            modelBuilder.Entity<StudentExam>().HasData(
                new StudentExam() { Id = 1, ExamId = 1 , StudentId = 1 , Degree = 0},
                new StudentExam() { Id = 2, ExamId = 2 , StudentId = 1 , Degree = 0}
                );

        }
    }
}
