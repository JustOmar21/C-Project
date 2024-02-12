using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace C__Project.Migrations
{
    /// <inheritdoc />
    public partial class AddedUniqueConstraintForExamQuestionAndSeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ExamQuestions_QuestionId",
                table: "ExamQuestions");

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Menofia", "ITI Menofia" },
                    { 2, "Beni Suef", "ITI Beni Suef" },
                    { 3, "Btengan", "ITI Btengan" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "MaxDegree", "MinDegree", "Name" },
                values: new object[,]
                {
                    { 1, "Whatever", 100, 50, "C#" },
                    { 2, "Whatever", 100, 70, "SQL" },
                    { 3, "Whatever", 100, 10, "ASP DOTNET" }
                });

            migrationBuilder.InsertData(
                table: "Intakes",
                columns: new[] { "Id", "EndTime", "Name", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Intake 42", new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "Intake 43", new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2026, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "Intake 44", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "Email", "Type", "Password" },
                values: new object[] { "tarekes68@gmail.com", "Student", "123456789sS" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "BranchId", "Floor", "Name" },
                values: new object[,]
                {
                    { 1, 1, 1, "MN Class 1" },
                    { 2, 1, 2, "MN Class 2" },
                    { 3, 1, 3, "MN Class 3" },
                    { 4, 2, 1, "BS Class 1" },
                    { 5, 2, 2, "BS Class 2" },
                    { 6, 2, 3, "BS Class 3" },
                    { 7, 3, 1, "BT Class 1" },
                    { 8, 3, 2, "BT Class 2" },
                    { 9, 3, 3, "BT Class 3" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "BranchId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Internet of Things" },
                    { 2, 2, "Strike Back" },
                    { 3, 3, "Watermelon" },
                    { 4, 1, "Web Development" },
                    { 5, 2, "Bad Sugarcane Juice" },
                    { 6, 3, "Banana" },
                    { 7, 1, "Good Sugarcane Juice" },
                    { 8, 2, "Headphones" },
                    { 9, 3, "Apples" }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CourseId", "EndTime", "InstructorId", "Name", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 2, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), null, "Exam 1", new DateTime(2024, 2, 13, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2024, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), null, "Exam 2", new DateTime(2024, 12, 13, 15, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Body", "CorrectChoiceNumber", "CourseId", "InstructorId", "Type" },
                values: new object[,]
                {
                    { 1, "Correct Choice is 1", 1, 1, null, "MCQ" },
                    { 2, "Correct Choice is 2", 2, 1, null, "TF" },
                    { 3, "Correct Choice is 3", 3, 1, null, "MCQ" },
                    { 4, "Correct Choice is 4", 4, 1, null, "MCQ" },
                    { 5, "Correct Choice is 1", 1, 1, null, "TF" },
                    { 6, "Correct Choice is 3", 3, 1, null, "MCQ" },
                    { 7, "Correct Choice is 2", 2, 1, null, "TF" },
                    { 8, "Correct Choice is 1", 1, 1, null, "TF" },
                    { 9, "Correct Choice is 4", 4, 1, null, "MCQ" },
                    { 10, "Correct Choice is 3", 3, 1, null, "MCQ" }
                });

            migrationBuilder.InsertData(
                table: "ExamQuestions",
                columns: new[] { "Id", "Degree", "ExamId", "QuestionId" },
                values: new object[,]
                {
                    { 1, 10, 1, 1 },
                    { 2, 10, 1, 2 },
                    { 3, 10, 1, 3 },
                    { 4, 10, 1, 4 },
                    { 5, 10, 1, 5 },
                    { 6, 10, 1, 6 },
                    { 7, 10, 1, 7 },
                    { 8, 10, 1, 8 },
                    { 9, 10, 1, 9 },
                    { 10, 10, 1, 10 }
                });

            migrationBuilder.InsertData(
                table: "QuestionChoices",
                columns: new[] { "ChoiceNumber", "QuestionId", "Choice" },
                values: new object[,]
                {
                    { 1, 1, "Choice 1" },
                    { 2, 1, "Choice 2" },
                    { 3, 1, "Choice 3" },
                    { 4, 1, "Choice 4" },
                    { 1, 2, "True" },
                    { 2, 2, "False" },
                    { 3, 2, null },
                    { 4, 2, null },
                    { 1, 3, "Choice 1" },
                    { 2, 3, "Choice 2" },
                    { 3, 3, "Choice 3" },
                    { 4, 3, "Choice 4" },
                    { 1, 4, "Choice 1" },
                    { 2, 4, "Choice 2" },
                    { 3, 4, "Choice 3" },
                    { 4, 4, "Choice 4" },
                    { 1, 5, "True" },
                    { 2, 5, "False" },
                    { 3, 5, null },
                    { 4, 5, null },
                    { 1, 6, "Choice 1" },
                    { 2, 6, "Choice 2" },
                    { 3, 6, "Choice 3" },
                    { 4, 6, "Choice 4" },
                    { 1, 7, "True" },
                    { 2, 7, "False" },
                    { 3, 7, null },
                    { 4, 7, null },
                    { 1, 8, "True" },
                    { 2, 8, "False" },
                    { 3, 8, null },
                    { 4, 8, null },
                    { 1, 9, "Choice 1" },
                    { 2, 9, "Choice 2" },
                    { 3, 9, "Choice 3" },
                    { 4, 9, "Choice 4" },
                    { 1, 10, "Choice 1" },
                    { 2, 10, "Choice 2" },
                    { 3, 10, "Choice 3" },
                    { 4, 10, "Choice 4" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "DepartmentId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 5, "No Way Jose", "DotNet Core" },
                    { 2, 7, "Ahmed is there", "Alexandria IOT" },
                    { 3, 1, "Bringing a wave of freedom", "Tsunami" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "DOB", "Email", "IntakeId", "Name", "TrackId" },
                values: new object[] { 1, 3, new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "tarekes68@gmail.com", 2, "Omar Tarek", 2 });

            migrationBuilder.InsertData(
                table: "StudentExams",
                columns: new[] { "Id", "Degree", "ExamId", "StudentId" },
                values: new object[,]
                {
                    { 1, 0, 1, 1 },
                    { 2, 0, 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestions_QuestionId_ExamId",
                table: "ExamQuestions",
                columns: new[] { "QuestionId", "ExamId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ExamQuestions_QuestionId_ExamId",
                table: "ExamQuestions");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExamQuestions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExamQuestions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExamQuestions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExamQuestions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExamQuestions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExamQuestions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExamQuestions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExamQuestions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExamQuestions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExamQuestions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Intakes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Intakes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumns: new[] { "Email", "Type" },
                keyValues: new object[] { "tarekes68@gmail.com", "Student" });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "QuestionChoices",
                keyColumns: new[] { "ChoiceNumber", "QuestionId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "StudentExams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentExams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Intakes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestions_QuestionId",
                table: "ExamQuestions",
                column: "QuestionId");
        }
    }
}
