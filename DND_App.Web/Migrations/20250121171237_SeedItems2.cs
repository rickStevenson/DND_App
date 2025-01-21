using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedItems2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Category", "Description", "Name", "Value", "Weight" },
                values: new object[,]
                {
                    { 1, "Weapon", "A versatile blade suitable for slashing and thrusting.", "Longsword", 15f, 3f },
                    { 2, "Armor", "A suit of interlocking metal rings providing solid protection.", "Chainmail", 75f, 55f },
                    { 3, "Potion", "A small vial of red liquid that restores health when consumed.", "Healing Potion", 50f, 0.5f },
                    { 4, "Gear", "A sturdy container to carry your belongings.", "Backpack", 2f, 5f },
                    { 5, "Gear", "A hooded lantern that casts bright light in a 30-foot radius.", "Lantern", 5f, 2f },
                    { 6, "Weapon", "A compact bow designed for quick, short-range shots.", "Shortbow", 25f, 2f },
                    { 7, "Gear", "A leather-bound tome containing the wizard’s spells.", "Spellbook", 50f, 3f },
                    { 8, "Gear", "A package of dried food sufficient for one day.", "Rations (1 day)", 0.5f, 2f },
                    { 9, "Weapon", "A small, sharp blade perfect for close combat or throwing.", "Dagger", 2f, 1f },
                    { 10, "Gear", "A hemp rope useful for climbing or securing items.", "Rope (50 feet)", 1f, 10f },
                    { 11, "Weapon", "A large axe designed for heavy combat.", "Battleaxe", 10f, 4f },
                    { 12, "Weapon", "A small axe usable in melee or as a thrown weapon.", "Handaxe", 5f, 2f },
                    { 13, "Weapon", "A hammer balanced for throwing.", "Throwing Hammer", 5f, 2f },
                    { 14, "Weapon", "A versatile hammer used for powerful strikes.", "Warhammer", 15f, 2f },
                    { 15, "Weapon", "A lightweight blade ideal for quick, precise strikes.", "Shortsword", 10f, 2f },
                    { 16, "Weapon", "A long-range bow capable of powerful shots.", "Longbow", 50f, 2f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
