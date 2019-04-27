using Microsoft.EntityFrameworkCore.Migrations;

namespace GF.Data.Migrations
{
    public partial class ModelCleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupJoinLinks_Groups_GroupId",
                table: "GroupJoinLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupJoinLinks_AspNetUsers_UserId",
                table: "GroupJoinLinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupJoinLinks",
                table: "GroupJoinLinks");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2c900c56-c3cf-411a-80f4-13ce11bd7bc7", "1f1106a8-118a-4886-a7fa-54fa8558561c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7e67defa-ab99-4bcf-a96f-c94a59f3cbf2", "3d992fdd-a55d-401f-be7c-bea84cd9ba48" });

            migrationBuilder.RenameTable(
                name: "GroupJoinLinks",
                newName: "GroupUserLinks");

            migrationBuilder.RenameColumn(
                name: "GroupPicture",
                table: "Groups",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "AspNetUsers",
                newName: "ImageURL");

            migrationBuilder.RenameIndex(
                name: "IX_GroupJoinLinks_UserId",
                table: "GroupUserLinks",
                newName: "IX_GroupUserLinks_UserId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "GroupUserLinks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupUserLinks",
                table: "GroupUserLinks",
                columns: new[] { "GroupId", "UserId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "faf4f8ff-f72b-4be2-b96d-0a6011aa60b4", "ed723444-0965-422c-868d-b69a6c034b22", "AppUser", "APPUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d17593c6-1b2c-42a7-8d84-cc28b30f2ed0", "320c8f11-4b98-4455-ad64-7326da38cdca", "SuperUser", "SUPERUSER" });

            migrationBuilder.AddForeignKey(
                name: "FK_GroupUserLinks_Groups_GroupId",
                table: "GroupUserLinks",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupUserLinks_AspNetUsers_UserId",
                table: "GroupUserLinks",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupUserLinks_Groups_GroupId",
                table: "GroupUserLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupUserLinks_AspNetUsers_UserId",
                table: "GroupUserLinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupUserLinks",
                table: "GroupUserLinks");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d17593c6-1b2c-42a7-8d84-cc28b30f2ed0", "320c8f11-4b98-4455-ad64-7326da38cdca" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "faf4f8ff-f72b-4be2-b96d-0a6011aa60b4", "ed723444-0965-422c-868d-b69a6c034b22" });

            migrationBuilder.DropColumn(
                name: "Id",
                table: "GroupUserLinks");

            migrationBuilder.RenameTable(
                name: "GroupUserLinks",
                newName: "GroupJoinLinks");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Groups",
                newName: "GroupPicture");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "AspNetUsers",
                newName: "ProfilePicture");

            migrationBuilder.RenameIndex(
                name: "IX_GroupUserLinks_UserId",
                table: "GroupJoinLinks",
                newName: "IX_GroupJoinLinks_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupJoinLinks",
                table: "GroupJoinLinks",
                columns: new[] { "GroupId", "UserId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c900c56-c3cf-411a-80f4-13ce11bd7bc7", "1f1106a8-118a-4886-a7fa-54fa8558561c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e67defa-ab99-4bcf-a96f-c94a59f3cbf2", "3d992fdd-a55d-401f-be7c-bea84cd9ba48", "Admin", "ADMIN" });

            migrationBuilder.AddForeignKey(
                name: "FK_GroupJoinLinks_Groups_GroupId",
                table: "GroupJoinLinks",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupJoinLinks_AspNetUsers_UserId",
                table: "GroupJoinLinks",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
