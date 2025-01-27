using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialDnDDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "Treasures",
                newName: "Treasures",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "Spells",
                newName: "Spells",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "Skills",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "RaceWeaponProficiency",
                newName: "RaceWeaponProficiency",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "RaceToolProficiency",
                newName: "RaceToolProficiency",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "RaceAbility",
                newName: "RaceAbility",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Items",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "IdentityUser<Guid>",
                newName: "IdentityUser<Guid>",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "ClassSavingThrows",
                newName: "ClassSavingThrows",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "ClassAbilities",
                newName: "ClassAbilities",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "CharacterTreasures",
                newName: "CharacterTreasures",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "CharacterSpells",
                newName: "CharacterSpells",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "CharacterSkills",
                newName: "CharacterSkills",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "Characters",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "CharacterRaces",
                newName: "CharacterRaces",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "CharacterItems",
                newName: "CharacterItems",
                newSchema: "DND_DbSchema");

            migrationBuilder.RenameTable(
                name: "CharacterClasses",
                newName: "CharacterClasses",
                newSchema: "DND_DbSchema");

            migrationBuilder.UpdateData(
                schema: "DND_DbSchema",
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Rations 1 day");

            migrationBuilder.UpdateData(
                schema: "DND_DbSchema",
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Rope 50 feet");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Treasures",
                schema: "DND_DbSchema",
                newName: "Treasures");

            migrationBuilder.RenameTable(
                name: "Spells",
                schema: "DND_DbSchema",
                newName: "Spells");

            migrationBuilder.RenameTable(
                name: "Skills",
                schema: "DND_DbSchema",
                newName: "Skills");

            migrationBuilder.RenameTable(
                name: "RaceWeaponProficiency",
                schema: "DND_DbSchema",
                newName: "RaceWeaponProficiency");

            migrationBuilder.RenameTable(
                name: "RaceToolProficiency",
                schema: "DND_DbSchema",
                newName: "RaceToolProficiency");

            migrationBuilder.RenameTable(
                name: "RaceAbility",
                schema: "DND_DbSchema",
                newName: "RaceAbility");

            migrationBuilder.RenameTable(
                name: "Items",
                schema: "DND_DbSchema",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "IdentityUser<Guid>",
                schema: "DND_DbSchema",
                newName: "IdentityUser<Guid>");

            migrationBuilder.RenameTable(
                name: "ClassSavingThrows",
                schema: "DND_DbSchema",
                newName: "ClassSavingThrows");

            migrationBuilder.RenameTable(
                name: "ClassAbilities",
                schema: "DND_DbSchema",
                newName: "ClassAbilities");

            migrationBuilder.RenameTable(
                name: "CharacterTreasures",
                schema: "DND_DbSchema",
                newName: "CharacterTreasures");

            migrationBuilder.RenameTable(
                name: "CharacterSpells",
                schema: "DND_DbSchema",
                newName: "CharacterSpells");

            migrationBuilder.RenameTable(
                name: "CharacterSkills",
                schema: "DND_DbSchema",
                newName: "CharacterSkills");

            migrationBuilder.RenameTable(
                name: "Characters",
                schema: "DND_DbSchema",
                newName: "Characters");

            migrationBuilder.RenameTable(
                name: "CharacterRaces",
                schema: "DND_DbSchema",
                newName: "CharacterRaces");

            migrationBuilder.RenameTable(
                name: "CharacterItems",
                schema: "DND_DbSchema",
                newName: "CharacterItems");

            migrationBuilder.RenameTable(
                name: "CharacterClasses",
                schema: "DND_DbSchema",
                newName: "CharacterClasses");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Rations_1day");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Rope_50feet");
        }
    }
}
