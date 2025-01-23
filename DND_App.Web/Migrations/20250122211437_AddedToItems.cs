using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedToItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArmorClassBonus",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                column: "ArmorClassBonus",
                value: 0);

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorClassBonus", "Category", "Cost", "Damage", "DamageType", "Description", "HPRegained", "Name", "Properties", "Rarity", "Stealth", "Strength", "Value", "Weight" },
                values: new object[,]
                {
                    { 17, 2, 1, "Shield", "500 gp", "", "", "A magical shield that offers increased protection.", "", "Shield +1", "Magical Bonus (+1)", "Rare", "", "", 500f, 6f },
                    { 18, 15, 2, "Armor", "2000 gp", "", "", "This armor grants superior magical protection.", "", "Armor +2", "Magical Bonus (+2)", "Very Rare", "Disadvantage", "Str 13", 2000f, 50f },
                    { 19, 0, 1, "Magic Item", "1500 gp", "", "", "This cloak increases the wearer's AC and saving throws.", "", "Cloak Of Protection", "Provides +1 bonus to AC and saving throws.", "Uncommon", "", "", 1500f, 1f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DropColumn(
                name: "ArmorClassBonus",
                table: "Items");
        }
    }
}
