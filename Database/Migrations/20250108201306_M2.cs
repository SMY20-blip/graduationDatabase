using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationDatabase.Migrations
{
    /// <inheritdoc />
    public partial class M2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_users",
                table: "tbl_users");

            migrationBuilder.RenameTable(
                name: "tbl_users",
                newName: "tbl_Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Users",
                table: "tbl_Users",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Users",
                table: "tbl_Users");

            migrationBuilder.RenameTable(
                name: "tbl_Users",
                newName: "tbl_users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_users",
                table: "tbl_users",
                column: "Id");
        }
    }
}
