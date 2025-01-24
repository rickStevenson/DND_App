using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class RevertChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the existing foreign key for CharacterItems -> Characters
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterItems_Characters_CharacterId",
                table: "CharacterItems");

            // Add the foreign key with cascade delete
            migrationBuilder.AddForeignKey(
                name: "FK_CharacterItems_Characters_CharacterId",
                table: "CharacterItems",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            // Repeat for other affected relationships
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSkills_Characters_CharacterId",
                table: "CharacterSkills");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSkills_Characters_CharacterId",
                table: "CharacterSkills",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSpells_Characters_CharacterId",
                table: "CharacterSpells");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSpells_Characters_CharacterId",
                table: "CharacterSpells",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterTreasures_Characters_CharacterId",
                table: "CharacterTreasures");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterTreasures_Characters_CharacterId",
                table: "CharacterTreasures",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Revert the cascade delete changes in the Down method
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterItems_Characters_CharacterId",
                table: "CharacterItems");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterItems_Characters_CharacterId",
                table: "CharacterItems",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSkills_Characters_CharacterId",
                table: "CharacterSkills");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSkills_Characters_CharacterId",
                table: "CharacterSkills",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSpells_Characters_CharacterId",
                table: "CharacterSpells");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSpells_Characters_CharacterId",
                table: "CharacterSpells",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterTreasures_Characters_CharacterId",
                table: "CharacterTreasures");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterTreasures_Characters_CharacterId",
                table: "CharacterTreasures",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

    }
}
