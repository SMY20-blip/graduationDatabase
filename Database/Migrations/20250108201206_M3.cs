using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationDatabase.Migrations
{
    /// <inheritdoc />
    public partial class M3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "tbl_users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_users",
                table: "tbl_users",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_users",
                table: "tbl_users");

            migrationBuilder.RenameTable(
                name: "tbl_users",
                newName: "users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");
        }
    }
}
