using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FridgeManager.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Fridges",
                newName: "FridgeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FridgeId",
                table: "Fridges",
                newName: "Id");
        }
    }
}
