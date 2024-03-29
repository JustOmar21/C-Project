﻿// <auto-generated />
using System;
using C__Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace C__Project.Migrations
{
    [DbContext(typeof(ExamSystemContext))]
    [Migration("20240208020203_addedTypeInstructorLogin")]
    partial class addedTypeInstructorLogin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("C__Project.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("C__Project.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("C__Project.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxDegree")
                        .HasColumnType("int");

                    b.Property<int>("MinDegree")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses", t =>
                        {
                            t.HasCheckConstraint("CK_Crs_MinDeg", "MinDegree > 0");

                            t.HasCheckConstraint("CK_Crs_MinMax", "MaxDegree > MinDegree");
                        });
                });

            modelBuilder.Entity("C__Project.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("C__Project.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Exams", t =>
                        {
                            t.HasCheckConstraint("CK_EX_StartEndTime", "StartTime < EndTime");

                            t.HasCheckConstraint("CK_EX_StartEndTimeDayDiff", "DATEDIFF(DAY, StartTime , EndTime) = 0 ");

                            t.HasCheckConstraint("CK_EX_StartEndTimeHourDiffAfter", "DATEDIFF(HOUR, StartTime , EndTime) <= 4 ");

                            t.HasCheckConstraint("CK_EX_StartEndTimeHourDiffBefore", "DATEDIFF(HOUR, StartTime , EndTime) >= 1 ");

                            t.HasCheckConstraint("CK_EX_StartTime", "DATEDIFF(YEAR, GetDate() , StartTime) >= 10");
                        });
                });

            modelBuilder.Entity("C__Project.Models.ExamQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("QuestionId");

                    b.ToTable("ExamQuestions", t =>
                        {
                            t.HasCheckConstraint("CK_EQ_Degree", "Degree > 0");
                        });
                });

            modelBuilder.Entity("C__Project.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Instructors", t =>
                        {
                            t.HasCheckConstraint("CK_Ins_DOB", "DATEDIFF(YEAR, DOB , GetDate()) >= 21");

                            t.HasCheckConstraint("CK_Ins_Salary", "Salary >= 4000");
                        });
                });

            modelBuilder.Entity("C__Project.Models.Intake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Intakes", t =>
                        {
                            t.HasCheckConstraint("CK_Int_StartEndTime", "StartTime < EndTime");

                            t.HasCheckConstraint("CK_Int_StartEndTimeMonths", "DATEDIFF(MONTH, StartTime , EndTime) >= 3");

                            t.HasCheckConstraint("CK_Int_StartTime", "DATEDIFF(YEAR, GetDate() , StartTime) <= 5");
                        });
                });

            modelBuilder.Entity("C__Project.Models.Login", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email", "Type");

                    b.ToTable("Logins", t =>
                        {
                            t.HasCheckConstraint("CK_Log_Type", "[Type] = 'Admin' OR [Type] = 'Student' OR [Type] = 'Manager' OR [Type] = 'Instructor'");
                        });

                    b.HasData(
                        new
                        {
                            Email = "Admin@gmail.com",
                            Type = "Admin",
                            Password = "123456789sS"
                        });
                });

            modelBuilder.Entity("C__Project.Models.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Managers", t =>
                        {
                            t.HasCheckConstraint("CK_MGR_DOB", "DATEDIFF(YEAR, DOB , GetDate()) >= 21");

                            t.HasCheckConstraint("CK_Mgr_Salary", "Salary >= 4000");
                        });
                });

            modelBuilder.Entity("C__Project.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CorrectChoiceNumber")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Questions", t =>
                        {
                            t.HasCheckConstraint("CK_Q_CCN", "CorrectChoiceNumber >= 1 AND CorrectChoiceNumber <= 4 ");

                            t.HasCheckConstraint("CK_Q_Type", "[Type] = 'MCQ' OR [Type] = 'TF'");
                        });
                });

            modelBuilder.Entity("C__Project.Models.QuestionChoices", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("ChoiceNumber")
                        .HasColumnType("int");

                    b.Property<string>("Choice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId", "ChoiceNumber");

                    b.ToTable("QuestionChoices", t =>
                        {
                            t.HasCheckConstraint("CK_QC_CN", "ChoiceNumber >= 1 AND ChoiceNumber <= 4 ");
                        });
                });

            modelBuilder.Entity("C__Project.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("IntakeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("IntakeId");

                    b.HasIndex("TrackId");

                    b.ToTable("Students", t =>
                        {
                            t.HasCheckConstraint("CK_Std_DOB", "DATEDIFF(YEAR, DOB , GetDate()) >= 15");
                        });
                });

            modelBuilder.Entity("C__Project.Models.StudentAnswer", b =>
                {
                    b.Property<int>("StudentExamId")
                        .HasColumnType("int");

                    b.Property<int>("ExamQuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("Answer")
                        .HasColumnType("int");

                    b.HasKey("StudentExamId", "ExamQuestionId");

                    b.HasIndex("ExamQuestionId");

                    b.ToTable("StudentAnswers");
                });

            modelBuilder.Entity("C__Project.Models.StudentExam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("StudentId", "ExamId")
                        .IsUnique();

                    b.ToTable("StudentExams", t =>
                        {
                            t.HasCheckConstraint("CK_SE_Degree", "Degree >= 0");
                        });
                });

            modelBuilder.Entity("C__Project.Models.TeachesAt", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "ClassId");

                    b.HasIndex("ClassId");

                    b.HasIndex("InstructorId");

                    b.ToTable("TeachesAts");
                });

            modelBuilder.Entity("C__Project.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("C__Project.Models.Class", b =>
                {
                    b.HasOne("C__Project.Models.Branch", "Branch")
                        .WithMany("Classes")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("C__Project.Models.Department", b =>
                {
                    b.HasOne("C__Project.Models.Branch", "Branch")
                        .WithMany("Departments")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("C__Project.Models.Exam", b =>
                {
                    b.HasOne("C__Project.Models.Course", "Course")
                        .WithMany("Exams")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C__Project.Models.Instructor", "Instructor")
                        .WithMany("Exams")
                        .HasForeignKey("InstructorId");

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("C__Project.Models.ExamQuestion", b =>
                {
                    b.HasOne("C__Project.Models.Exam", "Exam")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C__Project.Models.Question", "Question")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("C__Project.Models.Question", b =>
                {
                    b.HasOne("C__Project.Models.Course", "Course")
                        .WithMany("QuestionPool")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C__Project.Models.Instructor", "Instructor")
                        .WithMany("Questions")
                        .HasForeignKey("InstructorId");

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("C__Project.Models.QuestionChoices", b =>
                {
                    b.HasOne("C__Project.Models.Question", "Question")
                        .WithMany("Choices")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("C__Project.Models.Student", b =>
                {
                    b.HasOne("C__Project.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId");

                    b.HasOne("C__Project.Models.Intake", "Intake")
                        .WithMany("Students")
                        .HasForeignKey("IntakeId");

                    b.HasOne("C__Project.Models.Track", "Track")
                        .WithMany("Students")
                        .HasForeignKey("TrackId");

                    b.Navigation("Class");

                    b.Navigation("Intake");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("C__Project.Models.StudentAnswer", b =>
                {
                    b.HasOne("C__Project.Models.ExamQuestion", "ExamQuestion")
                        .WithMany("Answers")
                        .HasForeignKey("ExamQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C__Project.Models.StudentExam", "StudentExam")
                        .WithMany("Answers")
                        .HasForeignKey("StudentExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExamQuestion");

                    b.Navigation("StudentExam");
                });

            modelBuilder.Entity("C__Project.Models.StudentExam", b =>
                {
                    b.HasOne("C__Project.Models.Exam", "Exam")
                        .WithMany("Students")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C__Project.Models.Student", "Student")
                        .WithMany("Exams")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("C__Project.Models.TeachesAt", b =>
                {
                    b.HasOne("C__Project.Models.Class", "Class")
                        .WithMany("TeachesClass")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C__Project.Models.Course", "Course")
                        .WithMany("TeachesClass")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C__Project.Models.Instructor", "Instructor")
                        .WithMany("TeachesClass")
                        .HasForeignKey("InstructorId");

                    b.Navigation("Class");

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("C__Project.Models.Track", b =>
                {
                    b.HasOne("C__Project.Models.Department", "Department")
                        .WithMany("Tracks")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("C__Project.Models.Branch", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("C__Project.Models.Class", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("TeachesClass");
                });

            modelBuilder.Entity("C__Project.Models.Course", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("QuestionPool");

                    b.Navigation("TeachesClass");
                });

            modelBuilder.Entity("C__Project.Models.Department", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("C__Project.Models.Exam", b =>
                {
                    b.Navigation("ExamQuestions");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("C__Project.Models.ExamQuestion", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("C__Project.Models.Instructor", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Questions");

                    b.Navigation("TeachesClass");
                });

            modelBuilder.Entity("C__Project.Models.Intake", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("C__Project.Models.Question", b =>
                {
                    b.Navigation("Choices");

                    b.Navigation("ExamQuestions");
                });

            modelBuilder.Entity("C__Project.Models.Student", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("C__Project.Models.StudentExam", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("C__Project.Models.Track", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
