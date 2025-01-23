using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArmorClass",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cost",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Damage",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DamageType",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HPRegained",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Properties",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rarity",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stealth",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Strength",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "15 gp", "1d8", "Slashing", "", "Versatile (1d10)", "Common", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 16, "75 gp", "", "", "", "", "Common", "Disadvantage", "Str 13" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "50 gp", "", "", "2d4+2", "Consumable", "Uncommon", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "2 gp", "", "", "", "Can hold up to 30 lbs of items", "Common", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "5 gp", "", "", "", "Light source; bright light in a 30-foot radius and dim light for an additional 30 feet", "Common", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "25 gp", "1d6", "Piercing", "", "Range (80/320), Ammunition", "Common", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "50 gp", "", "", "", "Holds prepared spells", "Common", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "5 sp", "", "", "", "Consumable", "Common", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "2 gp", "1d4", "Piercing", "", "Finesse, Light, Thrown (range 20/60)", "Common", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "1 gp", "", "", "", "50 feet", "Common", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "10 gp", "1d8", "Slashing", "", "Versatile (1d10)", "Common", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "5 gp", "1d6", "Slashing", "", "Light, Thrown (range 20/60)", "Common", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "5 gp", "1d4", "Bludgeoning", "", "Light, Thrown (range 20/60)", "Common", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "15 gp", "1d8", "Bludgeoning", "", "Versatile (1d10)", "Common", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "10 gp", "1d6", "Piercing", "", "Finesse, Light", "Common", "", "" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArmorClass", "Cost", "Damage", "DamageType", "HPRegained", "Properties", "Rarity", "Stealth", "Strength" },
                values: new object[] { 0, "50 gp", "1d8", "Piercing", "", "Range (150/600), Ammunition, Heavy, Two-Handed", "Common", "", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArmorClass",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Damage",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "DamageType",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "HPRegained",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Properties",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Rarity",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Stealth",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Strength",
                table: "Items");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
