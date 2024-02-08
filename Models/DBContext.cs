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
                new Login() { Email="Admin@gmail.com" , Password="123456789sS" , Type="Admin"}
                );

            modelBuilder.Entity<Question>().ToTable(Q => Q.HasCheckConstraint("CK_Q_CCN", "CorrectChoiceNumber >= 1 AND CorrectChoiceNumber <= 4 "));
            modelBuilder.Entity<Question>().ToTable(Q => Q.HasCheckConstraint("CK_Q_Type", "[Type] = 'MCQ' OR [Type] = 'TF'"));

            modelBuilder.Entity<QuestionChoices>().HasKey(QC => new { QC.QuestionId, QC.ChoiceNumber });
            modelBuilder.Entity<QuestionChoices>().ToTable(QC => QC.HasCheckConstraint("CK_QC_CN", "ChoiceNumber >= 1 AND ChoiceNumber <= 4 "));

            modelBuilder.Entity<StudentAnswer>().HasKey(SA => new { SA.StudentExamId, SA.ExamQuestionId });

            modelBuilder.Entity<StudentExam>().HasIndex(SE => new { SE.StudentId, SE.ExamId }).IsUnique();
            modelBuilder.Entity<StudentExam>().ToTable(SE => SE.HasCheckConstraint("CK_SE_Degree", "Degree >= 0"));

            modelBuilder.Entity<ExamQuestion>().ToTable(EQ => EQ.HasCheckConstraint("CK_EQ_Degree", "Degree > 0"));

            modelBuilder.Entity<TeachesAt>().HasKey(TA => new { TA.CourseId, TA.ClassId });

            modelBuilder.Entity<Exam>().ToTable(EX => EX.HasCheckConstraint("CK_EX_StartEndTime", "StartTime < EndTime"));
            modelBuilder.Entity<Exam>().ToTable(EX => EX.HasCheckConstraint("CK_EX_StartTime", "DATEDIFF(YEAR, GetDate() , StartTime) >= 10"));
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

        }
    }
}
