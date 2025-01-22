using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkExample.Migrations
{
    /// <inheritdoc />
    public partial class AddCoursesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_StudentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Students");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "ClassStartDate", "Fees", "IsActive", "Title" },
                values: new object[,]
                {
                    { -2, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 333.0, true, "xyz Course" },
                    { -1, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9999.0, true, "ABC Course" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentId",
                table: "Students",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_StudentId",
                table: "Students",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }
    }
}
