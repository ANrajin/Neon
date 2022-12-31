using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Neon.Web.Data.Migrations
{
    public partial class Add_Role_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("1c57c706-662c-46e7-8240-839f1a9acd0c"), "52D1D3ED-4B63-44FD-89B0-7380F49F6DDA", "Author", "AUTHOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("ccd9fe14-ef0a-4b7f-9741-e7d968e0ab88"), "6A6F0469-939D-4F04-84BD-7469C7F84120", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c57c706-662c-46e7-8240-839f1a9acd0c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ccd9fe14-ef0a-4b7f-9741-e7d968e0ab88"));
        }
    }
}
