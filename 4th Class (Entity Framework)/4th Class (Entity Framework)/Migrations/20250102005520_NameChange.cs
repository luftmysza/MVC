using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4th_Class__Entity_Framework_.Migrations
{
    /// <inheritdoc />
    public partial class NameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Catogories_CategoryId",
                table: "Films");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catogories",
                table: "Catogories");

            migrationBuilder.RenameTable(
                name: "Catogories",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Categories_CategoryId",
                table: "Films",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Categories_CategoryId",
                table: "Films");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Catogories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catogories",
                table: "Catogories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Catogories_CategoryId",
                table: "Films",
                column: "CategoryId",
                principalTable: "Catogories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
