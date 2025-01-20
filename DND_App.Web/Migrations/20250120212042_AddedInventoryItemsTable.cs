using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedInventoryItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Skip primary key creation since it's already defined
            // Skip foreign key creation since it exists manually

            // Any new operations can be added here if needed
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // If needed, drop constraints or keys added manually
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterItems_Characters_CharacterId",
                table: "CharacterItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterItems_Items_ItemId",
                table: "CharacterItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterItems",
                table: "CharacterItems");
        }
    }
}
