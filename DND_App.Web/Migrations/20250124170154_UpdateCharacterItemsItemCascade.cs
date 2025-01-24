using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCharacterItemsItemCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the existing foreign key for CharacterItems -> Items
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterItems_Items_ItemId",
                table: "CharacterItems");

            // Add the foreign key with cascade delete
            migrationBuilder.AddForeignKey(
                name: "FK_CharacterItems_Items_ItemId",
                table: "CharacterItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the foreign key with cascade delete
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterItems_Items_ItemId",
                table: "CharacterItems");

            // Add the foreign key back with NO_ACTION (restrict delete)
            migrationBuilder.AddForeignKey(
                name: "FK_CharacterItems_Items_ItemId",
                table: "CharacterItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
