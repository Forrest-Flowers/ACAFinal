using Microsoft.EntityFrameworkCore.Migrations;

namespace GF.Data.Migrations
{
    public partial class indentityroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aa2f647f-1040-4bf0-9edb-c296e4f80d92", "f485b792-1b57-4c5f-9986-0318582f91e1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd068cea-75e6-4ed7-aecc-57e9809d71c6", "1e1c20c8-bd3d-415f-b5cc-a3d3f307372b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "aa2f647f-1040-4bf0-9edb-c296e4f80d92", "f485b792-1b57-4c5f-9986-0318582f91e1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "dd068cea-75e6-4ed7-aecc-57e9809d71c6", "1e1c20c8-bd3d-415f-b5cc-a3d3f307372b" });
        }
    }
}
