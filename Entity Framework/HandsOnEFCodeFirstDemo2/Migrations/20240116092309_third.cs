﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandsOnEFCodeFirstDemo2.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_marks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Exam = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    TotalMark = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_marks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_marks_tbl_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "tbl_students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_marks_StudentId",
                table: "tbl_marks",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_marks");
        }
    }
}
