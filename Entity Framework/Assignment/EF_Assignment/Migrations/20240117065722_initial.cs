using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    BookName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Language = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_book", x => x.BookId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_book");
        }
    }
}
