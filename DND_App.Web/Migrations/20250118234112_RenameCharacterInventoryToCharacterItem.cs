using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class RenameCharacterInventoryToCharacterItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the `Id` and `Notes` columns
            migrationBuilder.DropColumn(name: "Id", table: "CharacterInventory");
            migrationBuilder.DropColumn(name: "Notes", table: "CharacterInventory");

            // Rename the `CharacterInventory` table to `CharacterItem`
            migrationBuilder.RenameTable(name: "CharacterInventory", newName: "CharacterItem");

            // Update the primary key to use the composite key
            migrationBuilder.DropPrimaryKey(name: "PK_CharacterInventory", table: "CharacterItem");
            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterItem",
                table: "CharacterItem",
                columns: new[] { "CharacterId", "ItemId" });

            // Update foreign key constraints
            migrationBuilder.DropForeignKey(name: "FK_CharacterInventory_Characters_CharacterId", table: "CharacterItem");
            migrationBuilder.DropForeignKey(name: "FK_CharacterInventory_Item_ItemId", table: "CharacterItem");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterItem_Characters_CharacterId",
                table: "CharacterItem",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterItem_Item_ItemId",
                table: "CharacterItem",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Rename the table back to `CharacterInventory`
            migrationBuilder.RenameTable(name: "CharacterItem", newName: "CharacterInventory");

            // Add back the `Id` and `Notes` columns
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CharacterInventory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "CharacterInventory",
                type: "nvarchar(max)",
                nullable: true);

            // Update the primary key
            migrationBuilder.DropPrimaryKey(name: "PK_CharacterItem", table: "CharacterInventory");
            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterInventory",
                table: "CharacterInventory",
                column: "Id");

            // Restore foreign key constraints
            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInventory_Characters_CharacterId",
                table: "CharacterInventory",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterInventory_Item_ItemId",
                table: "CharacterInventory",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
