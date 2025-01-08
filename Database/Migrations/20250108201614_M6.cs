using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationDatabase.Migrations
{
    /// <inheritdoc />
    public partial class M6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Users",
                table: "tbl_Users");

            migrationBuilder.RenameTable(
                name: "tbl_Users",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "tbl_Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Users",
                table: "tbl_Users",
                column: "Id");
        }
    }
}
