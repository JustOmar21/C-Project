using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C__Project.Migrations
{
    /// <inheritdoc />
    public partial class fixedErrorwithSeedExam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 13, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 13, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Intakes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Intakes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Intakes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Intakes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Intakes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Intakes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2026, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
