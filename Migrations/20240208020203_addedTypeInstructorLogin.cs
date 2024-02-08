using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C__Project.Migrations
{
    /// <inheritdoc />
    public partial class addedTypeInstructorLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Log_Type",
                table: "Logins");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Log_Type",
                table: "Logins",
                sql: "[Type] = 'Admin' OR [Type] = 'Student' OR [Type] = 'Manager' OR [Type] = 'Instructor'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Log_Type",
                table: "Logins");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Log_Type",
                table: "Logins",
                sql: "[Type] = 'Admin' OR [Type] = 'Student' OR [Type] = 'Manager'");
        }
    }
}
