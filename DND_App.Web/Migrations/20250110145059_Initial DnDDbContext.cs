using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialDnDDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HitDie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterRaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrengthBonus = table.Column<int>(type: "int", nullable: false),
                    DexterityBonus = table.Column<int>(type: "int", nullable: false),
                    ConstitutionBonus = table.Column<int>(type: "int", nullable: false),
                    IntelligenceBonus = table.Column<int>(type: "int", nullable: false),
                    WisdomBonus = table.Column<int>(type: "int", nullable: false),
                    CharismaBonus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterRaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUser<Guid>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser<Guid>", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abilities_CharacterClasses_CharacterClassId",
                        column: x => x.CharacterClassId,
                        principalTable: "CharacterClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassSavingThrows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingThrows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavingThrows_CharacterClasses_CharacterClassId",
                        column: x => x.CharacterClassId,
                        principalTable: "CharacterClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceAbility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterRaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceAbility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaceAbility_CharacterRaces_CharacterRaceId",
                        column: x => x.CharacterRaceId,
                        principalTable: "CharacterRaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceToolProficiency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterRaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceToolProficiency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaceToolProficiency_CharacterRaces_CharacterRaceId",
                        column: x => x.CharacterRaceId,
                        principalTable: "CharacterRaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceWeaponProficiency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterRaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceWeaponProficiency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaceWeaponProficiency_CharacterRaces_CharacterRaceId",
                        column: x => x.CharacterRaceId,
                        principalTable: "CharacterRaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharacterClassId = table.Column<int>(type: "int", nullable: false),
                    CharacterRaceId = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    ExperiencePoints = table.Column<int>(type: "int", nullable: false),
                    PassiveWisdom = table.Column<int>(type: "int", nullable: false),
                    Inspiration = table.Column<bool>(type: "bit", nullable: false),
                    ProficiencyBonus = table.Column<int>(type: "int", nullable: false),
                    ArmorClass = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_CharacterClasses_CharacterClassId",
                        column: x => x.CharacterClassId,
                        principalTable: "CharacterClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_CharacterRaces_CharacterRaceId",
                        column: x => x.CharacterRaceId,
                        principalTable: "CharacterRaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_IdentityUser<Guid>_UserId",
                        column: x => x.UserId,
                        principalTable: "IdentityUser<Guid>",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CharacterClasses",
                columns: new[] { "Id", "HitDie", "Name" },
                values: new object[,]
                {
                    { 1, 12, "Barbarian" },
                    { 2, 8, "Bard" },
                    { 3, 8, "Cleric" },
                    { 4, 8, "Druid" },
                    { 5, 10, "Fighter" },
                    { 6, 8, "Monk" },
                    { 7, 10, "Paladin" },
                    { 8, 10, "Ranger" },
                    { 9, 8, "Rogue" },
                    { 10, 6, "Sorcerer" },
                    { 11, 8, "Warlock" },
                    { 12, 6, "Wizard" }
                });

            migrationBuilder.InsertData(
                table: "CharacterRaces",
                columns: new[] { "Id", "CharismaBonus", "ConstitutionBonus", "DexterityBonus", "IntelligenceBonus", "Name", "StrengthBonus", "WisdomBonus" },
                values: new object[,]
                {
                    { 1, 1, 0, 0, 2, "Aasimar", 0, 0 },
                    { 2, 1, 0, 0, 0, "Dragonborn", 2, 0 },
                    { 3, 0, 2, 0, 0, "Dwarf", 0, 0 },
                    { 4, 0, 0, 2, 0, "Elf", 0, 0 },
                    { 5, 0, 0, 0, 0, "Firbolg", 1, 2 },
                    { 6, 0, 0, 1, 0, "Air Genasi", 0, 0 },
                    { 7, 0, 0, 0, 0, "Earth Genasi", 1, 0 },
                    { 8, 0, 0, 1, 0, "Fire Genasi", 0, 0 },
                    { 9, 0, 1, 0, 0, "Water Genasi", 0, 0 },
                    { 10, 0, 0, 0, 2, "Gnome", 0, 0 },
                    { 11, 0, 1, 0, 0, "Goliath", 2, 0 },
                    { 12, 2, 0, 0, 0, "Half-Elf", 0, 0 },
                    { 13, 0, 0, 2, 0, "Halfling", 0, 0 },
                    { 14, 0, 1, 0, 0, "Half-Orc", 2, 0 },
                    { 15, 1, 1, 1, 1, "Human", 1, 1 },
                    { 16, 0, 0, 2, 0, "Kenku", 0, 0 },
                    { 17, 0, 0, 2, 0, "Tabaxi", 0, 0 },
                    { 18, 2, 0, 0, 1, "Tiefling", 0, 0 },
                    { 19, 0, 1, 0, 0, "Tortle", 2, 0 },
                    { 20, 2, 0, 0, 1, "Yuan-Ti Pureblood", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "ClassAbilities",
                columns: new[] { "Id", "CharacterClassId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Rage" },
                    { 2, 1, "Unarmored Defense" },
                    { 3, 2, "Bardic Inspiration" },
                    { 4, 2, "Song of Rest" },
                    { 5, 3, "Turn Undead" },
                    { 6, 3, "Divine Intervention" },
                    { 7, 4, "Wild Shape" },
                    { 8, 4, "DruidicCircle" },
                    { 9, 5, "Second Wind" },
                    { 10, 5, "Action Surge" },
                    { 11, 6, "Martial Arts" },
                    { 12, 6, "Ki Points" },
                    { 13, 7, "Lay on Hands" },
                    { 14, 7, "Divine Smite" },
                    { 15, 8, "Favored Enemy" },
                    { 16, 8, "Natural Explorer" },
                    { 17, 9, "Sneak Attack" },
                    { 18, 9, "Cunning Action" },
                    { 19, 10, "Metamagic" },
                    { 20, 10, "Font of Magic" },
                    { 21, 11, "Eldritch Invocations" },
                    { 22, 11, "Pact Magic" },
                    { 23, 12, "Arcane Recovery" },
                    { 24, 12, "Spell Mastery" }
                });

            migrationBuilder.InsertData(
                table: "RaceAbility",
                columns: new[] { "Id", "CharacterRaceId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "DwarvenVision" },
                    { 2, 1, "Healing Hands" },
                    { 3, 2, "Breath Weapon" },
                    { 4, 2, "Draconic Ancestry" },
                    { 5, 3, "DwarvenVision" },
                    { 6, 3, "Dwarven Resilience" },
                    { 7, 4, "Keen Senses" },
                    { 8, 4, "Fey Ancestry" },
                    { 9, 5, "Firbolg Magic" },
                    { 10, 5, "Hidden Step" },
                    { 11, 6, "Unending Breath" },
                    { 12, 6, "Mingle with the Wind" },
                    { 13, 7, "Earth Walk" },
                    { 14, 7, "Merge with Stone" },
                    { 15, 8, "DwarvenVision" },
                    { 16, 8, "Fire Resistance" },
                    { 17, 9, "Acid Resistance" },
                    { 18, 9, "ShellDefense" },
                    { 19, 10, "Gnome Cunning" },
                    { 20, 10, "DwarvenVision" },
                    { 21, 11, "Mountain Born" },
                    { 22, 11, "Powerful Build" },
                    { 23, 12, "DwarvenVision" },
                    { 24, 12, "Skill Versatility" },
                    { 25, 13, "Lucky" },
                    { 26, 13, "Brave" },
                    { 27, 14, "Relentless Endurance" },
                    { 28, 14, "Savage Attack" },
                    { 29, 15, "Versatile Ability" },
                    { 30, 16, "Mimicry" },
                    { 31, 16, "Expert Forgery" },
                    { 32, 17, "Cat’s Claws" },
                    { 33, 17, "Feline Agility" },
                    { 34, 18, "Infernal Legacy" },
                    { 35, 18, "Hellish Resistance" },
                    { 36, 19, "Natural Armor" },
                    { 37, 19, "Hold Breath" },
                    { 38, 20, "Magic Resistance" },
                    { 39, 20, "Poison Immunity" }
                });

            migrationBuilder.InsertData(
                table: "RaceToolProficiency",
                columns: new[] { "Id", "CharacterRaceId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Alchemist's Supplies" },
                    { 2, 1, "Calligrapher's Supplies" },
                    { 3, 1, "Herbalism Kit" },
                    { 4, 1, "Musical Instrument" },
                    { 5, 1, "Painter's Supplies" },
                    { 6, 2, "Smith's Tools" },
                    { 7, 2, "Brewer's Supplies" },
                    { 8, 2, "Calligrapher's Supplies" },
                    { 9, 2, "Mason's Tools" },
                    { 10, 2, "Dragonchess Set" },
                    { 11, 3, "Smith's Tools" },
                    { 13, 3, "Brewer's Supplies" },
                    { 14, 3, "Mason's Tools" },
                    { 15, 4, "Herbalism Kit" },
                    { 16, 4, "Calligrapher's Supplies" },
                    { 17, 4, "Musical Instrument" },
                    { 18, 4, "Painter's Supplies" },
                    { 19, 4, "Alchemist's Supplies" },
                    { 20, 5, "Herbalism Kit" },
                    { 21, 5, "Carpenter's Tools" },
                    { 22, 5, "Cook's Utensils" },
                    { 23, 5, "Mason's Tools" },
                    { 24, 5, "Painter's Supplies" },
                    { 25, 6, "Navigator's Tools" },
                    { 26, 6, "Cartographer's Tools" },
                    { 27, 6, "Tinker's Tools" },
                    { 28, 6, "Flute" },
                    { 29, 6, "Calligrapher's Supplies" },
                    { 30, 7, "Smith's Tools" },
                    { 31, 7, "Mason's Tools" },
                    { 32, 7, "Miner's Tools" },
                    { 33, 7, "Potter's Tools" },
                    { 34, 7, "Cartographer's Tools" },
                    { 35, 8, "Alchemist's Supplies" },
                    { 36, 8, "Glassblower's Tools" },
                    { 37, 8, "Smith's Tools" },
                    { 38, 8, "Cook's Utensils" },
                    { 39, 8, "Brewer's Supplies" },
                    { 40, 9, "Navigator's Tools" },
                    { 41, 9, "Fishing Tackle" },
                    { 42, 9, "Cartographer's Tools" },
                    { 43, 9, "Cook's Utensils" },
                    { 44, 9, "Brewer's Supplies" },
                    { 45, 10, "Tinker's Tools" },
                    { 46, 10, "Alchemist's Supplies" },
                    { 47, 10, "Artisan's Tools" },
                    { 48, 10, "Cartographer's Tools" },
                    { 49, 10, "Painter's Supplies" },
                    { 50, 11, "Smith's Tools" },
                    { 51, 11, "Mason's Tools" },
                    { 52, 11, "Carpenter's Tools" },
                    { 53, 11, "Cook's Utensils" },
                    { 54, 11, "Brewer's Supplies" },
                    { 55, 12, "Fiddle" },
                    { 56, 12, "Calligrapher's Supplies" },
                    { 57, 12, "Painter's Supplies" },
                    { 58, 12, "Alchemist's Supplies" },
                    { 59, 12, "Jeweler's Tools" },
                    { 60, 13, "Cook's Utensils" },
                    { 61, 13, "Brewer's Supplies" },
                    { 62, 13, "Weaver's Tools" },
                    { 63, 13, "Woodcarver's Tools" },
                    { 64, 13, "Herbalism Kit" },
                    { 65, 14, "Smith's Tools" },
                    { 66, 14, "Leatherworker's Tools" },
                    { 67, 14, "Carpenter's Tools" },
                    { 68, 14, "Cook's Utensils" },
                    { 69, 14, "Brewer's Supplies" },
                    { 70, 15, "Smith's Tools" },
                    { 71, 15, "Farmer's Tools" },
                    { 72, 15, "Mason's Tools" },
                    { 73, 15, "Brewer's Supplies" },
                    { 74, 15, "Herbalism Kit" },
                    { 75, 16, "Calligrapher's Supplies" },
                    { 76, 16, "Disguise Kit" },
                    { 77, 16, "Tinker's Tools" },
                    { 78, 16, "Thieves' Tools" },
                    { 79, 16, "Painter's Supplies" },
                    { 80, 17, "Cartographer's Tools" },
                    { 81, 17, "Calligrapher's Supplies" },
                    { 82, 17, "Painter's Supplies" },
                    { 83, 17, "Drums" },
                    { 84, 17, "Thieves' Tools" },
                    { 85, 18, "Alchemist's Supplies" },
                    { 86, 18, "Calligrapher's Supplies" },
                    { 87, 18, "Disguise Kit" },
                    { 88, 18, "Lyre" },
                    { 89, 18, "Forgery Kit" },
                    { 90, 19, "Mason's Tools" },
                    { 91, 19, "Carpenter's Tools" },
                    { 92, 19, "Cook's Utensils" },
                    { 93, 19, "Fishing Tackle" },
                    { 94, 19, "Herbalism Kit" },
                    { 95, 20, "Poisoner's Kit" },
                    { 96, 20, "Alchemist's Supplies" },
                    { 97, 20, "Disguise Kit" },
                    { 98, 20, "Forgery Kit" },
                    { 99, 20, "Calligrapher's Supplies" }
                });

            migrationBuilder.InsertData(
                table: "RaceWeaponProficiency",
                columns: new[] { "Id", "CharacterRaceId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "None" },
                    { 2, 2, "None" },
                    { 3, 3, "Battleaxe" },
                    { 4, 3, "Handaxe" },
                    { 5, 3, "Throwing Hammer" },
                    { 6, 3, "Warhammer" },
                    { 7, 4, "Longsword" },
                    { 8, 4, "Shortsword" },
                    { 9, 4, "Shortbow" },
                    { 10, 4, "Longbow" },
                    { 11, 5, "None" },
                    { 12, 6, "None" },
                    { 13, 7, "None" },
                    { 14, 8, "None" },
                    { 15, 9, "None" },
                    { 16, 10, "None" },
                    { 17, 11, "None" },
                    { 18, 12, "Longsword" },
                    { 19, 12, "Shortsword" },
                    { 20, 12, "Shortbow" },
                    { 21, 12, "Longbow" },
                    { 22, 13, "None" },
                    { 23, 14, "None" },
                    { 24, 15, "Longsword" },
                    { 25, 15, "Shortsword" },
                    { 26, 16, "None" },
                    { 27, 17, "None" },
                    { 28, 18, "None" },
                    { 29, 19, "None" },
                    { 30, 20, "None" }
                });

            migrationBuilder.InsertData(
                table: "ClassSavingThrows",
                columns: new[] { "Id", "CharacterClassId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Strength" },
                    { 2, 1, "Constitution" },
                    { 3, 2, "Dexterity" },
                    { 4, 2, "Charisma" },
                    { 5, 3, "Wisdom" },
                    { 6, 3, "Charisma" },
                    { 7, 4, "Intelligence" },
                    { 8, 4, "Wisdom" },
                    { 9, 5, "Strength" },
                    { 10, 5, "Constitution" },
                    { 11, 6, "Strength" },
                    { 12, 6, "Dexterity" },
                    { 13, 7, "Wisdom" },
                    { 14, 7, "Charisma" },
                    { 15, 8, "Strength" },
                    { 16, 8, "Dexterity" },
                    { 17, 9, "Dexterity" },
                    { 18, 9, "Intelligence" },
                    { 19, 10, "Constitution" },
                    { 20, 10, "Charisma" },
                    { 21, 11, "Wisdom" },
                    { 22, 11, "Charisma" },
                    { 23, 12, "Intelligence" },
                    { 24, 12, "Wisdom" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_CharacterClassId",
                table: "ClassAbilities",
                column: "CharacterClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterClassId",
                table: "Characters",
                column: "CharacterClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterRaceId",
                table: "Characters",
                column: "CharacterRaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceAbility_CharacterRaceId",
                table: "RaceAbility",
                column: "CharacterRaceId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceToolProficiency_CharacterRaceId",
                table: "RaceToolProficiency",
                column: "CharacterRaceId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceWeaponProficiency_CharacterRaceId",
                table: "RaceWeaponProficiency",
                column: "CharacterRaceId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrows_CharacterClassId",
                table: "ClassSavingThrows",
                column: "CharacterClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassAbilities");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "RaceAbility");

            migrationBuilder.DropTable(
                name: "RaceToolProficiency");

            migrationBuilder.DropTable(
                name: "RaceWeaponProficiency");

            migrationBuilder.DropTable(
                name: "ClassSavingThrows");

            migrationBuilder.DropTable(
                name: "IdentityUser<Guid>");

            migrationBuilder.DropTable(
                name: "CharacterRaces");

            migrationBuilder.DropTable(
                name: "CharacterClasses");
        }
    }
}
