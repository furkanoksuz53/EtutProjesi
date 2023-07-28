using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EtutProject.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Teachers",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Etuts",
                newName: "EtutId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Branches",
                newName: "BranchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Teachers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EtutId",
                table: "Etuts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Branches",
                newName: "Id");
        }
    }
}
