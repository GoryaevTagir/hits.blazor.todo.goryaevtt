using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "CreatedDate", "Description", "FinishDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 11, 18, 1, 19, 24, 526, DateTimeKind.Local).AddTicks(1581), "tsad1", new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4103), "sad" },
                    { 2, new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4298), "tsad2", new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4300), "happ" },
                    { 3, new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4300), "tsad3", new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4301), "abg" },
                    { 4, new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4302), "tsad4", new DateTime(2026, 11, 18, 1, 19, 24, 527, DateTimeKind.Local).AddTicks(4302), "abdsg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");
        }
    }
}
