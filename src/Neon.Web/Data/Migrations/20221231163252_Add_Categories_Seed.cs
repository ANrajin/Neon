using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Neon.Web.Data.Migrations
{
    public partial class Add_Categories_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "Title", "UrlTitle" },
                values: new object[] { 1, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum", "Programming Languages", "programming-languages" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "Title", "UrlTitle" },
                values: new object[] { 2, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum", "SOLID Principles", "solid-principles" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "Title", "UrlTitle" },
                values: new object[] { 3, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum", "Frameworks", "frameworks" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
