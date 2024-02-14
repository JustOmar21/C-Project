using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C__Project.Migrations
{
    /// <inheritdoc />
    public partial class FixedStartTimeCK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_EX_StartTime",
                table: "Exams");

            migrationBuilder.AddCheckConstraint(
                name: "CK_EX_StartTime",
                table: "Exams",
                sql: "DATEDIFF(YEAR, GetDate() , StartTime) <= 10");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_EX_StartTime",
                table: "Exams");

            migrationBuilder.AddCheckConstraint(
                name: "CK_EX_StartTime",
                table: "Exams",
                sql: "DATEDIFF(YEAR, GetDate() , StartTime) >= 10");
        }
    }
}
