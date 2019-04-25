using Microsoft.EntityFrameworkCore.Migrations;

namespace GF.Data.Migrations
{
    public partial class addedidtojoinentity : Migration
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
                keyValues: new object[] { "03a55f79-163a-403b-a43c-b901b49b8aea", "50028e5c-7a33-4c30-a1fe-909fcd926578" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9c9a4535-451d-4ba8-8daf-84007e368580", "c1990929-1963-45a8-98b1-83dd4d3f3816" });

            migrationBuilder.RenameTable(
                name: "GroupJoinLinks",
                newName: "GroupUserLinks");

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
                values: new object[] { "d34ec2f2-d405-4ff3-a2eb-65773958ccd0", "aad7007b-28f9-451e-8554-a542020fadf6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2ef98cf-0667-4106-9f07-3279eafcf692", "fb339c85-96f1-4bbc-9e54-0409b8137e9a", "Admin", "ADMIN" });

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
                keyValues: new object[] { "d2ef98cf-0667-4106-9f07-3279eafcf692", "fb339c85-96f1-4bbc-9e54-0409b8137e9a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d34ec2f2-d405-4ff3-a2eb-65773958ccd0", "aad7007b-28f9-451e-8554-a542020fadf6" });

            migrationBuilder.DropColumn(
                name: "Id",
                table: "GroupUserLinks");

            migrationBuilder.RenameTable(
                name: "GroupUserLinks",
                newName: "GroupJoinLinks");

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
                values: new object[] { "03a55f79-163a-403b-a43c-b901b49b8aea", "50028e5c-7a33-4c30-a1fe-909fcd926578", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c9a4535-451d-4ba8-8daf-84007e368580", "c1990929-1963-45a8-98b1-83dd4d3f3816", "Admin", "ADMIN" });

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
