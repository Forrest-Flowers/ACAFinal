using Microsoft.EntityFrameworkCore.Migrations;

namespace GF.Data.Migrations
{
    public partial class changepicturenamestoImageURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "35fa314e-84e8-4506-897a-f43c7502a2b0", "6cdc97f4-3523-414e-9738-5437c308c924" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e5f53d48-b008-4a73-a2df-2891298951dd", "bd53aea2-59b8-415b-b901-b3488b7dc4fd" });

            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "AspNetUsers",
                newName: "ImageURL");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03a55f79-163a-403b-a43c-b901b49b8aea", "50028e5c-7a33-4c30-a1fe-909fcd926578", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c9a4535-451d-4ba8-8daf-84007e368580", "c1990929-1963-45a8-98b1-83dd4d3f3816", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "03a55f79-163a-403b-a43c-b901b49b8aea", "50028e5c-7a33-4c30-a1fe-909fcd926578" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9c9a4535-451d-4ba8-8daf-84007e368580", "c1990929-1963-45a8-98b1-83dd4d3f3816" });

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "AspNetUsers",
                newName: "ProfilePicture");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35fa314e-84e8-4506-897a-f43c7502a2b0", "6cdc97f4-3523-414e-9738-5437c308c924", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5f53d48-b008-4a73-a2df-2891298951dd", "bd53aea2-59b8-415b-b901-b3488b7dc4fd", "Admin", "ADMIN" });
        }
    }
}
