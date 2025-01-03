using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4th_Class__Entity_Framework_.Migrations
{
    /// <inheritdoc />
    public partial class NameChange2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Films",
                newName: "Rating");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Films",
                newName: "Price");
        }
    }
}
