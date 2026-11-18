using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitem2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2026, 11, 18, 1, 19, 24, 526, DateTimeKind.Local).AddTicks(1581), new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4298), new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4300), new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4302), new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4302) });
        }
    }
}
