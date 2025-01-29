using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class ChangedConstantsToEnums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterTreasures_Treasures_TreasureId",
                table: "CharacterTreasures");

            

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Celestial Resistance");

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Firbolg Magic");

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Speech Of Beast And Leaf");

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Natural Athlete");

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "Magic Resistance");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Alchemist's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Calligrapher's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Herbalism Kit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Musical Instrument");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Painter's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Smith's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Brewer's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Calligrapher's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Mason's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Dragonchess Set");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Smith's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Brewer's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Mason's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Herbalism Kit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Calligrapher's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Musical Instrument");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Painter's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Alchemist's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Herbalism Kit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Carpenter's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Cook's Utensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "Mason's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "Painter's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Navigator's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Cartographer's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "Tinker's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Calligrapher's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Smith's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "Mason's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "Miner's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "Potter's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Cartographer's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Alchemist's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "Glassblower's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "Smith's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 38,
                column: "Name",
                value: "Cook's Utensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "Brewer's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 40,
                column: "Name",
                value: "Navigator's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 41,
                column: "Name",
                value: "Fishing Tackle");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "Cartographer's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "Cook's Utensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 44,
                column: "Name",
                value: "Brewer's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "Tinker's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "Alchemist's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 47,
                column: "Name",
                value: "Artisan's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 48,
                column: "Name",
                value: "Cartographer's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 49,
                column: "Name",
                value: "Painter's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "Smith's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 51,
                column: "Name",
                value: "Mason's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "Carpenter's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 53,
                column: "Name",
                value: "Cook's Utensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 54,
                column: "Name",
                value: "Brewer's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 56,
                column: "Name",
                value: "Calligrapher's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "Painter's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 58,
                column: "Name",
                value: "Alchemist's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 59,
                column: "Name",
                value: "Jeweler's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 60,
                column: "Name",
                value: "Cook's Utensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Brewer's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Weaver's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Woodcarver's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Herbalism Kit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 65,
                column: "Name",
                value: "Smith's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Leatherworker's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Carpenter's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Cook's Utensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Brewer's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "Smith's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 71,
                column: "Name",
                value: "Farmer's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 72,
                column: "Name",
                value: "Mason's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 73,
                column: "Name",
                value: "Brewer's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 74,
                column: "Name",
                value: "Herbalism Kit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 75,
                column: "Name",
                value: "Calligrapher's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 76,
                column: "Name",
                value: "Disguise Kit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "Tinker's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 78,
                column: "Name",
                value: "Thieves' Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 79,
                column: "Name",
                value: "Painter's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 80,
                column: "Name",
                value: "Cartographer's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 81,
                column: "Name",
                value: "Calligrapher's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 82,
                column: "Name",
                value: "Painter's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 84,
                column: "Name",
                value: "Thieves' Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 85,
                column: "Name",
                value: "Alchemist's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 86,
                column: "Name",
                value: "Calligrapher's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 87,
                column: "Name",
                value: "Disguise Kit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 89,
                column: "Name",
                value: "Forgery Kit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 90,
                column: "Name",
                value: "Mason's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 91,
                column: "Name",
                value: "Carpenter's Tools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 92,
                column: "Name",
                value: "Cook's Utensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 93,
                column: "Name",
                value: "Fishing Tackle");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 94,
                column: "Name",
                value: "Herbalism Kit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 95,
                column: "Name",
                value: "Poisoner's Kit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 96,
                column: "Name",
                value: "Alchemist's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 97,
                column: "Name",
                value: "Disguise Kit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 98,
                column: "Name",
                value: "Forgery Kit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 99,
                column: "Name",
                value: "Calligrapher's Supplies");

            migrationBuilder.UpdateData(
                table: "RaceWeaponProficiency",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Throwing Hammer");

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CastingTime", "Name" },
                values: new object[] { "1 Action", "Cure Wounds" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CastingTime", "Duration" },
                values: new object[] { "1 Reaction", "1 Round" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CastingTime", "Name", "SpellRange" },
                values: new object[] { "1 Action", "Magic Missle", "120 feet" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CastingTime", "Duration", "Name", "SpellRange" },
                values: new object[] { "1 Action", "10 minutes", "Detect Magic", "30 feet" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CastingTime", "Duration", "SpellRange" },
                values: new object[] { "1 Action", "1 Minute", "30 feet" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CastingTime", "Name", "SpellRange" },
                values: new object[] { "Bonus Action", "Misty Step", "30 feet" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CastingTime", "Duration" },
                values: new object[] { "1 Action", "Up to 1 Hour" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CastingTime", "Duration", "Name", "SpellRange" },
                values: new object[] { "1 Action", "Up to 1 Minute", "Hold Person", "60 feet" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CastingTime", "Name", "SpellRange" },
                values: new object[] { "1 Action", "Scorching Ray", "120 feet" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CastingTime", "Duration", "Name" },
                values: new object[] { "1 Action", "1 Hour", "Enhance Ability" });

            

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterTreasures_Treasures_TreasureId",
                table: "CharacterTreasures",
                column: "TreasureId",
                principalTable: "Treasures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop FK from "CharacterTreasures" table
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterTreasures_Treasures_TreasureId",
                table: "CharacterTreasures");

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Celestial Resitance");

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Firbolg MagicArmor");

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Speach Of Beast And Leaf");

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Natual Athlete");

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "MagicArmor Resistance");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "AlchemistsSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "CalligraphersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "HerbalismKit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "MusicalInstrument");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "PaintersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "SmithsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "BrewersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "CalligraphersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "MasonsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "DragonchessSet");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "SmithsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "BrewersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "MasonsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "HerbalismKit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "CalligraphersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "MusicalInstrument");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "PaintersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "AlchemistsSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "HerbalismKit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "CarpenterTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "CooksUtensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "MasonsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "PaintersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "NavigatorsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "CartographerTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "TinkersTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "CalligraphersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "SmithsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "MasonsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "MinersTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "PottersTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "CartographerTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "AlchemistsSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "GlassblowersTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "SmithsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 38,
                column: "Name",
                value: "CooksUtensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "BrewersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 40,
                column: "Name",
                value: "NavigatorsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 41,
                column: "Name",
                value: "FishingTackle");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "CartographerTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "CooksUtensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 44,
                column: "Name",
                value: "BrewersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "TinkersTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "AlchemistsSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 47,
                column: "Name",
                value: "ArtisansTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 48,
                column: "Name",
                value: "CartographerTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 49,
                column: "Name",
                value: "PaintersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "SmithsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 51,
                column: "Name",
                value: "MasonsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "CarpenterTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 53,
                column: "Name",
                value: "CooksUtensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 54,
                column: "Name",
                value: "BrewersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 56,
                column: "Name",
                value: "CalligraphersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "PaintersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 58,
                column: "Name",
                value: "AlchemistsSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 59,
                column: "Name",
                value: "JewelersTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 60,
                column: "Name",
                value: "CooksUtensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "BrewersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "WeaversTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "WoodcarversTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "HerbalismKit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 65,
                column: "Name",
                value: "SmithsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "LeatherworkerTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "CarpenterTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "CooksUtensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "BrewersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "SmithsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 71,
                column: "Name",
                value: "FarmersTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 72,
                column: "Name",
                value: "MasonsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 73,
                column: "Name",
                value: "BrewersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 74,
                column: "Name",
                value: "HerbalismKit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 75,
                column: "Name",
                value: "CalligraphersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 76,
                column: "Name",
                value: "DisguiseKit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "TinkersTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 78,
                column: "Name",
                value: "ThievesTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 79,
                column: "Name",
                value: "PaintersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 80,
                column: "Name",
                value: "CartographerTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 81,
                column: "Name",
                value: "CalligraphersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 82,
                column: "Name",
                value: "PaintersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 84,
                column: "Name",
                value: "ThievesTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 85,
                column: "Name",
                value: "AlchemistsSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 86,
                column: "Name",
                value: "CalligraphersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 87,
                column: "Name",
                value: "DisguiseKit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 89,
                column: "Name",
                value: "ForgeryKit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 90,
                column: "Name",
                value: "MasonsTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 91,
                column: "Name",
                value: "CarpenterTools");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 92,
                column: "Name",
                value: "CooksUtensils");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 93,
                column: "Name",
                value: "FishingTackle");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 94,
                column: "Name",
                value: "HerbalismKit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 95,
                column: "Name",
                value: "PoisonersKit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 96,
                column: "Name",
                value: "AlchemistsSupplies");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 97,
                column: "Name",
                value: "DisguiseKit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 98,
                column: "Name",
                value: "ForgeryKit");

            migrationBuilder.UpdateData(
                table: "RaceToolProficiency",
                keyColumn: "Id",
                keyValue: 99,
                column: "Name",
                value: "CalligraphersSupplies");

            migrationBuilder.UpdateData(
                table: "RaceWeaponProficiency",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "ThrowingHammer");

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CastingTime", "Name" },
                values: new object[] { "_1Action", "CureWounds" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CastingTime", "Duration" },
                values: new object[] { "_1Reaction", "_1Round" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CastingTime", "Name", "SpellRange" },
                values: new object[] { "_1Action", "MagicMissle", "_120feet" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CastingTime", "Duration", "Name", "SpellRange" },
                values: new object[] { "_1Action", "_10minutes", "DetectMagic", "_30feet" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CastingTime", "Duration", "SpellRange" },
                values: new object[] { "_1Action", "_1Minute", "_30feet" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CastingTime", "Name", "SpellRange" },
                values: new object[] { "BonusAction", "MistyStep", "_30feet" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CastingTime", "Duration" },
                values: new object[] { "_1Action", "Upto1Hour" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CastingTime", "Duration", "Name", "SpellRange" },
                values: new object[] { "_1Action", "Upto1Minute", "HoldPerson", "_60feet" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CastingTime", "Name", "SpellRange" },
                values: new object[] { "_1Action", "ScorchingRay", "_120feet" });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CastingTime", "Duration", "Name" },
                values: new object[] { "_1Action", "_1Hour", "EnhanceAbility" });

            

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterTreasures_TreasureType_TreasureId",
                table: "CharacterTreasures",
                column: "TreasureId",
                principalTable: "TreasureType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
