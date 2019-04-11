using Microsoft.EntityFrameworkCore.Migrations;

namespace GF.Data.Migrations
{
    public partial class groupuserlinkfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Groups_GroupId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_GroupId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "aa2f647f-1040-4bf0-9edb-c296e4f80d92", "f485b792-1b57-4c5f-9986-0318582f91e1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "dd068cea-75e6-4ed7-aecc-57e9809d71c6", "1e1c20c8-bd3d-415f-b5cc-a3d3f307372b" });

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "GroupJoinLinks");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "IsUserAdmin",
                table: "GroupJoinLinks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c900c56-c3cf-411a-80f4-13ce11bd7bc7", "1f1106a8-118a-4886-a7fa-54fa8558561c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e67defa-ab99-4bcf-a96f-c94a59f3cbf2", "3d992fdd-a55d-401f-be7c-bea84cd9ba48", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2c900c56-c3cf-411a-80f4-13ce11bd7bc7", "1f1106a8-118a-4886-a7fa-54fa8558561c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7e67defa-ab99-4bcf-a96f-c94a59f3cbf2", "3d992fdd-a55d-401f-be7c-bea84cd9ba48" });

            migrationBuilder.DropColumn(
                name: "IsUserAdmin",
                table: "GroupJoinLinks");

            migrationBuilder.AddColumn<string>(
                name: "AdminId",
                table: "Groups",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "GroupJoinLinks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aa2f647f-1040-4bf0-9edb-c296e4f80d92", "f485b792-1b57-4c5f-9986-0318582f91e1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd068cea-75e6-4ed7-aecc-57e9809d71c6", "1e1c20c8-bd3d-415f-b5cc-a3d3f307372b", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GroupId",
                table: "AspNetUsers",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Groups_GroupId",
                table: "AspNetUsers",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
