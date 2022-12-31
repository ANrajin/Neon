using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Neon.Web.Data.Migrations
{
    public partial class Add_Admin_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b9cb67f7-02cc-4ead-9874-7cd9a589935f"), 0, "70025A6E-E282-4F03-BD99-9578C3895334", "admin@neon.com", true, "Super", "Admin", false, new DateTimeOffset(new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), "ADMIN@NEON.COM", "ADMIN", "AQAAAAEAACcQAAAAEFRWEmRJXlkqidHuaXRKu6PDZdeUB2z3ScEdA2glTbr6NWo3uFiTDf4BbyRsIxC0yg==", "01782044014", true, null, false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("ccd9fe14-ef0a-4b7f-9741-e7d968e0ab88"), new Guid("b9cb67f7-02cc-4ead-9874-7cd9a589935f") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ccd9fe14-ef0a-4b7f-9741-e7d968e0ab88"), new Guid("b9cb67f7-02cc-4ead-9874-7cd9a589935f") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b9cb67f7-02cc-4ead-9874-7cd9a589935f"));
        }
    }
}
