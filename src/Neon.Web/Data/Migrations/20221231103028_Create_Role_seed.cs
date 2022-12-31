using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Neon.Web.Data.Migrations
{
    public partial class Create_Role_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1C57C706-662C-46E7-8240-839F1A9ACD0C", "e719ef30-2f80-4075-88c4-f60fe98c215b", "Author", "AUTHOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "CCD9FE14-EF0A-4B7F-9741-E7D968E0AB88", "3af6937b-5d29-4f18-8498-690b147ed17b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1C57C706-662C-46E7-8240-839F1A9ACD0C");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CCD9FE14-EF0A-4B7F-9741-E7D968E0AB88");
        }
    }
}
