using Microsoft.EntityFrameworkCore.Migrations;

namespace GF.Data.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "JoinRequestStatuses",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "New" },
                    { 2, "Pending" },
                    { 3, "Accepted" },
                    { 4, "Denied" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JoinRequestStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JoinRequestStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JoinRequestStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JoinRequestStatuses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
