using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C__Project.Migrations
{
    /// <inheritdoc />
    public partial class fixedIntakeSTerror : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Int_StartTime",
                table: "Intakes");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Int_StartTime",
                table: "Intakes",
                sql: "DATEDIFF(YEAR, GetDate() , StartTime) <= 5");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Int_StartTime",
                table: "Intakes");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Int_StartTime",
                table: "Intakes",
                sql: "DATEDIFF(YEAR, GetDate() , StartTime) >= 5");
        }
    }
}
