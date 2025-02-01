using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedItemsToItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorClassBonus", "Category", "Cost", "Damage", "DamageType", "Description", "HPRegained", "Name", "Properties", "Rarity", "Stealth", "Strength", "Value", "Weight" },
                values: new object[,]
                {
                    { 20, 11, 0, "Armor", "10 GP", "None", "None", "Made of supple and tanned hide, leather armor is a light armor option.", "None", "Leather Armor", "Light Armor", "Common", "None", "None", 10f, 10f },
                    { 21, 13, 0, "Armor", "50 GP", "None", "None", "A chain shirt is a flexible suit of interlocking metal rings, providing moderate protection.", "None", "Chain Shirt", "Medium Armor", "Common", "None", "None", 50f, 20f },
                    { 22, 18, 0, "Armor", "1500 GP", "None", "None", "Plate consists of shaped, interlocking metal plates covering the entire body. It provides the best protection available.", "None", "Plate Armor", "Heavy Armor", "Common", "Disadvantage", "15", 1500f, 65f },
                    { 23, 0, 2, "Armor", "10 GP", "None", "None", "A simple, sturdy shield that bolsters the wearer's defenses.", "None", "Shield", "Shield", "Common", "None", "None", 10f, 6f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23);
        }
    }
}
