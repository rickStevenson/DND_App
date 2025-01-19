using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class IntitialMigration : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrengthBonus = table.Column<int>(type: "int", nullable: false),
                    DexterityBonus = table.Column<int>(type: "int", nullable: false),
                    ConstitutionBonus = table.Column<int>(type: "int", nullable: false),
                    IntelligenceBonus = table.Column<int>(type: "int", nullable: false),
                    WisdomBonus = table.Column<int>(type: "int", nullable: false),
                    CharismaBonus = table.Column<int>(type: "int", nullable: false),
                    MaleImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FemaleImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlignedAttribute = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    IsPrepared = table.Column<bool>(type: "bit", nullable: false),
                    CastingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpellRange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiresConcentration = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassAbilities_CharacterClasses_CharacterClassId",
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
                    table.PrimaryKey("PK_ClassSavingThrows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassSavingThrows_CharacterClasses_CharacterClassId",
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    CharacterImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharacterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterClassId = table.Column<int>(type: "int", nullable: false),
                    CharacterRaceId = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    ExperiencePoints = table.Column<int>(type: "int", nullable: false),
                    Alignment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacterBackstory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    HitPoints_Total = table.Column<int>(type: "int", nullable: false),
                    HitPoints_Current = table.Column<int>(type: "int", nullable: false),
                    PassiveWisdom = table.Column<int>(type: "int", nullable: false),
                    Inspiration = table.Column<bool>(type: "bit", nullable: false),
                    ProficiencyBonus = table.Column<int>(type: "int", nullable: false),
                    ArmorClass = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Initiative = table.Column<int>(type: "int", nullable: false),
                    TotalWeight = table.Column<float>(type: "real", nullable: false),
                    EncumbranceStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eyes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hair = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalityTraits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ideals = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bonds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flaws = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "CharacterItem",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterInventory", x => new { x.CharacterId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_CharacterInventory_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterInventory_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSkills",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    IsProficient = table.Column<bool>(type: "bit", nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSkills", x => new { x.CharacterId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CharacterSkills_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSpells",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    SpellId = table.Column<int>(type: "int", nullable: false),
                    IsLearned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSpells", x => new { x.CharacterId, x.SpellId });
                    table.ForeignKey(
                        name: "FK_CharacterSpells_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSpells_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CharacterClasses",
                columns: new[] { "Id", "Description", "HitDie", "Name" },
                values: new object[,]
                {
                    { 1, "Barbarians are fierce warriors driven by primal instincts and raw rage. They thrive in the heat of battle, using their fury to fuel their strength and durability. Barbarians often hail from wild, untamed lands and have a deep connection to their ancestors or the forces of nature. Their unbridled rage makes them a force to be reckoned with on the battlefield, capable of shrugging off damage that would fell lesser warriors.", 12, "Barbarian" },
                    { 2, "Bards are versatile spellcasters and performers who weave magic through music, storytelling, or art. They are masters of inspiration, using their talents to bolster allies, deceive enemies, and shape the flow of battle. Bards are naturally charismatic and adaptable, often serving as diplomats, spies, or leaders. Their broad skill set allows them to thrive in almost any situation.", 8, "Bard" },
                    { 3, "Clerics are divine spellcasters who draw their power from their connection to a deity or cosmic force. They serve as healers, protectors, and champions of their faith, often embodying the ideals of their chosen domain. Clerics can wield both divine magic and martial weapons, making them a versatile class capable of supporting allies or smiting foes.", 8, "Cleric" },
                    { 4, "Druids are mystical spellcasters who draw power from nature and the elements. They are guardians of the natural world, using their magic to protect the balance between civilization and wilderness. Druids can shapeshift into animals, summon the forces of nature, and wield elemental magic, making them highly adaptable.", 8, "Druid" },
                    { 5, "Fighters are masters of combat, trained in a wide variety of weapons and fighting techniques. They are highly versatile warriors who excel in physical confrontations, whether using brute strength, precise technique, or advanced tactics. Fighters can specialize in many styles, from sword-and-shield defense to dual-wielding offense or archery.", 10, "Fighter" },
                    { 6, "Monks are disciplined martial artists who channel their inner energy, or ki, to perform extraordinary feats. They are masters of unarmed combat and agility, moving with precision and speed to outmaneuver their enemies. Monks often hail from monasteries or other ascetic traditions, devoting their lives to physical and spiritual perfection.", 8, "Monk" },
                    { 7, "Paladins are holy warriors bound by a sacred oath to uphold justice, protect the innocent, and smite evil. They combine divine magic with martial prowess, serving as paragons of virtue or champions of their sworn cause. Their devotion grants them supernatural abilities to heal, protect allies, and punish foes with divine retribution.", 10, "Paladin" },
                    { 8, "Rangers are expert trackers and hunters who thrive in the wilderness. They are adept at surviving in harsh environments and are skilled at hunting specific foes. Rangers use a combination of martial skill and nature magic to protect the wilds or navigate it as part of their adventuring lifestyle. They often form deep connections with nature, animals, or specific terrains.", 10, "Ranger" },
                    { 9, "Rogues are cunning and resourceful characters who excel in stealth, agility, and precision. They are masters of subterfuge and deception, capable of striking where it hurts the most. Rogues thrive in a variety of roles, from infiltrators and assassins to treasure hunters and thieves. Their ability to deal devastating damage with sneak attacks makes them a formidable presence in combat.", 8, "Rogue" },
                    { 10, "Sorcerers are innate spellcasters who wield magic drawn from a powerful bloodline or a mystical source within them. Unlike other spellcasters, sorcerers do not study or practice magic; instead, they manipulate raw magical energy through sheer willpower. Their mastery of metamagic allows them to shape spells in unique and devastating ways.", 6, "Sorcerer" },
                    { 11, "Warlocks gain their power through pacts with mysterious patrons—powerful entities such as fiends, fey, or eldritch beings. Their bond with their patron grants them unique magical abilities and spells, often reflecting the nature of the pact. Warlocks are versatile and adaptable, wielding both potent spells and eldritch invocations to shape their magic in creative ways.", 8, "Warlock" },
                    { 12, "Wizards are scholarly spellcasters who dedicate their lives to mastering the arcane. They study spellbooks to learn and prepare a vast array of spells, making them the most versatile magic-users. Wizards rely on their intelligence and preparation to control the battlefield, protect their allies, or destroy their enemies. Their mastery of magic is unparalleled in variety and depth.", 6, "Wizard" }
                });

            migrationBuilder.InsertData(
                table: "CharacterRaces",
                columns: new[] { "Id", "CharismaBonus", "ConstitutionBonus", "Description", "DexterityBonus", "FemaleImage", "IntelligenceBonus", "MaleImage", "Name", "StrengthBonus", "WisdomBonus" },
                values: new object[,]
                {
                    { 1, 1, 0, "Aasimar are beings touched by the divine. They serve as celestial champions, guardians of justice and virtue, and often possess a celestial guide to aid them in their quests. Aasimar are marked by their radiant appearance—gleaming eyes, a faint golden or silver sheen to their skin, and an aura of grace. They are driven by a sense of purpose to protect the weak, fight evil, and uphold righteousness.", 0, "/images/races/Aasimar_Female.png", 2, "/images/races/Aasimar_Male.png", "Aasimar", 0, 0 },
                    { 2, 1, 0, "Dragonborn are proud, draconic humanoids with ancestry linked to the great dragons. Their scales shimmer in hues tied to their draconic lineage—red, blue, green, or even metallic tones. They exude strength and confidence and often bear a natural affinity for leadership. Dragonborn breathe an element of their dragon heritage, whether fire, lightning, or frost, making them fearsome warriors on the battlefield.", 0, "/images/races/Dragonborn_Female.png", 0, "/images/races/Dragonborn_Male.png", "Dragonborn", 2, 0 },
                    { 3, 0, 2, "Dwarves are sturdy, hearty, and known for their unparalleled craftsmanship. They are short and stocky with a build designed for endurance. Dwarves are fiercely loyal to their kin, and their stronghold cities are engineering marvels carved deep into mountains. Their culture revolves around tradition, respect for ancestry, and a relentless work ethic.", 0, "/images/races/Dwarf_Female.png", 0, "/images/races/Dwarf_Male.png", "Dwarf", 0, 0 },
                    { 4, 0, 0, "Elves are graceful and otherworldly beings closely tied to nature and the arcane. With sharp features, pointed ears, and a timeless beauty, elves are creatures of both mystery and elegance. They live much longer than humans and tend to focus on mastering arts, magic, or combat during their lifetimes. Their connection to the Feywild grants them agility and other supernatural abilities.", 2, "/images/races/Elf_Female.png", 0, "/images/races/Elf_Male.png", "Elf", 0, 0 },
                    { 5, 0, 0, "Firbolgs are gentle giants connected to the natural world. They live in harmony with the forests, often serving as protectors of the wilds. Firbolgs are shy and reclusive, avoiding contact with the outside world unless their forests are threatened. Despite their peaceful demeanor, they possess incredible strength and innate magical abilities, allowing them to commune with nature and defend it.", 0, "/images/races/Firbolg_Female.png", 0, "/images/races/Firbolg_Male.png", "Firbolg", 1, 2 },
                    { 6, 0, 0, "Air Genasi are beings with elemental air ancestry, often descended from djinn. They are free-spirited and dynamic, embodying the essence of the wind. Their connection to the element of air makes them agile and quick, both in thought and movement. Air Genasi are often drawn to exploration and adventure, thriving in environments where they can experience freedom and movement.", 1, "/images/races/GenasiAir_Female.png", 0, "/images/races/GenasiAir_Male.png", "Air Genasi", 0, 0 },
                    { 7, 0, 0, "Earth Genasi have elemental earth ancestry, often traced back to dao. They are solid, steady, and reliable, with a physicality that seems carved from the earth itself. Earth Genasi are deeply grounded and unwavering in their decisions, often acting as anchors in chaotic situations. They feel a strong connection to stone and soil, often favoring lives of craftsmanship or exploration beneath the surface.", 0, "/images/races/GenasiEarth_Female.png", 0, "/images/races/GenasiEarth_Male.png", "Earth Genasi", 1, 0 },
                    { 8, 0, 0, "Fire Genasi are tied to the elemental power of fire, often through lineage connected to efreeti. They are passionate, intense, and prone to bursts of emotion. Their fiery nature often makes them charismatic and inspiring, but also volatile and quick-tempered. Fire Genasi are naturally drawn to heat and light, feeling most comfortable in warm environments.", 1, "/images/races/GenasiFire_Female.png", 0, "/images/races/GenasiFire_Male.png", "Fire Genasi", 0, 0 },
                    { 9, 0, 1, "Water Genasi possess a connection to elemental water, often through marid ancestry. They are fluid and adaptable, with a calming presence that reflects the stillness of a tranquil sea or the power of a raging storm. Water Genasi are drawn to aquatic environments and often feel at home near rivers, lakes, or oceans.", 0, "/images/races/GenasiWater_Female.png", 0, "/images/races/GenasiWater_Male.png", "Water Genasi", 0, 0 },
                    { 10, 0, 0, "Gnomes are whimsical, energetic, and endlessly curious. They are small but brimming with creativity, wit, and intelligence. Known for their ingenuity, gnomes are often inventors, alchemists, or skilled artisans. They are highly social and love storytelling, jokes, and puzzles. Gnomes are divided into subraces, with forest gnomes being connected to nature and rock gnomes excelling in invention and craftsmanship.", 0, "/images/races/Gnome_Female.png", 2, "/images/races/Gnome_Male.png", "Gnome", 0, 0 },
                    { 11, 0, 1, "Goliaths are towering, rugged humanoids who dwell in mountainous regions, living in harmony with their harsh environment. They are known for their immense strength, endurance, and competitive nature. Goliaths view life as a series of challenges to overcome, valuing strength and self-sufficiency above all else. Their culture is deeply tied to survival, with each individual striving to prove their worth to the tribe.", 0, "/images/races/Goliath_Female.png", 0, "/images/races/Goliath_Male.png", "Goliath", 2, 0 },
                    { 12, 2, 0, "Half-elves are the offspring of humans and elves, embodying the grace and agility of their elven heritage with the ambition and versatility of humanity. They often struggle to find a place in either culture, but their adaptability and charm allow them to thrive in diverse societies. Half-elves are natural diplomats, blending the best qualities of their dual heritage.", 0, "/images/races/HalfElf_Female.png", 0, "/images/races/HalfElf_Male.png", "Half-Elf", 0, 0 },
                    { 13, 0, 0, "Halflings are small, cheerful, and resourceful folk who live simple lives in tight-knit communities. They are known for their optimism, courage, and love of home and hearth. Despite their size, halflings possess remarkable agility and luck, often escaping danger through quick thinking or sheer serendipity. They prefer peaceful lives but are not afraid to rise to challenges when necessary.", 2, "/images/races/Halfling_Female.png", 0, "/images/races/Halfling_Male.png", "Halfling", 0, 0 },
                    { 14, 0, 1, "Half-orcs are the result of human and orc unions, combining the brute strength and resilience of orcs with human adaptability. They often face prejudice but channel their inner strength to prove their worth. Many half-orcs are driven by a desire to overcome their perceived savagery, seeking honor, redemption, or greatness in their lives.", 0, "/images/races/HalfOrc_Female.png", 0, "/images/races/HalfOrc_Male.png", "Half-Orc", 2, 0 },
                    { 15, 1, 1, "Humans are the most versatile and ambitious of all the races, thriving in nearly every environment and excelling in a wide variety of fields. Their relatively short lifespans drive them to achieve greatness quickly, whether through exploration, invention, or conquest. Humans are known for their adaptability, ingenuity, and the diversity of their cultures.", 1, "/images/races/Human_Female.png", 1, "/images/races/Human_Male.png", "Human", 1, 1 },
                    { 16, 0, 0, "Kenku are avian humanoids who resemble flightless crows or ravens. Once capable of flight and speech of their own, they were cursed long ago and now mimic the voices and sounds they hear around them. Kenku are resourceful and clever, often excelling as spies, thieves, or merchants. Their lack of original speech and creativity forces them to rely on imitation and cunning to survive in the world.", 2, "/images/races/Kenku_Female.png", 0, "/images/races/Kenku_Male.png", "Kenku", 0, 0 },
                    { 17, 0, 0, "Tabaxi are feline humanoids hailing from distant, exotic lands. They are naturally curious and driven by an insatiable wanderlust, always seeking out new stories, relics, and experiences. Tabaxi are agile and dexterous, often excelling as scouts, rogues, or bards. Their feline grace and inquisitive nature make them both charming and unpredictable.", 2, "/images/races/Tabaxi_Female.png", 0, "/images/races/Tabaxi_Male.png", "Tabaxi", 0, 0 },
                    { 18, 2, 0, "Tieflings are humanoids with infernal heritage, often descended from fiends or those who made pacts with devils. Their infernal bloodline is evident in their appearance—horns, tails, and glowing eyes mark them as different. Despite their fiendish origins, Tieflings are not inherently evil and often seek to rise above the stigma of their heritage, forging their own path in life.", 0, "/images/races/Tiefling_Female.png", 1, "/images/races/Tiefling_Male.png", "Tiefling", 0, 0 },
                    { 19, 0, 1, "Tortles are humanoid turtles, known for their calm demeanor and love of exploration. They carry their homes on their backs in the form of durable shells, making them self-reliant and capable of traveling wherever their curiosity takes them. Tortles are often wise and contemplative, with a deep connection to nature and a strong appreciation for life’s simple pleasures.", 0, "/images/races/Tortle_Female.png", 0, "/images/races/Tortle_Male.png", "Tortle", 2, 0 },
                    { 20, 2, 0, "Yuan-Ti Purebloods are snake-like humanoids descended from a once-great serpent empire. They are cold, calculating, and ambitious, often serving as spies, diplomats, or manipulators for their kind. Yuan-Ti Purebloods are the most human-looking of the Yuan-Ti, allowing them to infiltrate societies more easily, but their serpent features—such as scaled skin or slit-pupil eyes—betray their heritage.", 0, "/images/races/YuanTiPureblood_Female.png", 1, "/images/races/YuanTiPureblood_Male.png", "Yuan-Ti Pureblood", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "AlignedAttribute", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Strength", "Covers climbing, jumping, and swimming.", "Athletics" },
                    { 2, "Dexterity", "Covers balancing, tumbling, and avoiding falls.", "Acrobatics" },
                    { 3, "Dexterity", "Covers manual trickery like pickpocketing.", "SleightOfHand" },
                    { 4, "Dexterity", "Covers hiding and moving silently.", "Stealth" },
                    { 5, "Intelligence", "Covers knowledge of magic, spells, and artifacts.", "Arcana" },
                    { 6, "Intelligence", "Covers knowledge of historical events and lore.", "History" },
                    { 7, "Intelligence", "Covers finding clues and solving mysteries.", "Investigation" },
                    { 8, "Intelligence", "Covers knowledge of plants, animals, and natural phenomena.", "Nature" },
                    { 9, "Intelligence", "Covers knowledge of deities, rites, and holy symbols.", "Religion" },
                    { 10, "Wisdom", "Covers calming, controlling, and training animals.", "AnimalHandling" },
                    { 11, "Wisdom", "Covers reading body language and intentions.", "Insight" },
                    { 12, "Wisdom", "Covers stabilizing creatures and diagnosing ailments.", "Medicine" },
                    { 13, "Wisdom", "Covers noticing details and detecting hidden creatures or objects.", "Perception" },
                    { 14, "Wisdom", "Covers tracking, foraging, and surviving in the wild.", "Survival" },
                    { 15, "Charisma", "Covers convincing others of falsehoods.", "Deception" },
                    { 16, "Charisma", "Covers coercing others through threats or force.", "Intimidation" },
                    { 17, "Charisma", "Covers entertaining others through music, dance, or acting.", "Performance" },
                    { 18, "Charisma", "Covers influencing others with tact and social grace.", "Persuasion" }
                });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "CastingTime", "Description", "Duration", "IsPrepared", "Level", "Name", "RequiresConcentration", "School", "SpellRange" },
                values: new object[,]
                {
                    { 1, "1 Action", "A creature you touch regains hit points equal to 1d8 + your spellcasting modifier.", "Instant", false, 1, "Cure Wounds", false, "Evocation", "Touch" },
                    { 2, "1 Reaction", "You gain +5 to AC until the start of your next turn.", "1 Round", false, 1, "Shield", false, "Abjuration", "Self" },
                    { 3, "1 Action", "Create three glowing darts of force, each dealing 1d4+1 damage to a target.", "Instant", false, 1, "Magic Missle", false, "Evocation", "120 feet" },
                    { 4, "1 Action", "Sense the presence of magic within 30 feet for up to 10 minutes.", "10 minutes", false, 1, "Detect Magic", false, "Divination", "30 feet" },
                    { 5, "1 Action", "Up to three creatures gain +1d4 to attack rolls and saving throws for 1 minute.", "1 Minute", false, 1, "Bless", false, "Enchantment", "30 feet" },
                    { 6, "Bonus Action", "Teleport up to 30 feet to an unoccupied space you can see.", "Instant", false, 2, "Misty Step", false, "Conjuration", "30 feet" },
                    { 7, "1 Action", "A creature you touch becomes invisible until they attack or cast a spell.", "Up to 1 Hour", false, 2, "Invisibility", false, "Illusion", "Touch" },
                    { 8, "1 Action", "Paralyze a humanoid target for 1 minute, with repeated saves to escape.", "Up to 1 Minute", false, 2, "Hold Person", false, "Enchantment", "60 feet" },
                    { 9, "1 Action", "Fire three rays of fire, each dealing 2d6 fire damage on a hit.", "Instant", false, 2, "Scorching Ray", false, "Evocation", "120 feet" },
                    { 10, "1 Action", "Grant advantage on ability checks or other bonuses to the target.", "1 Hour", false, 2, "Enhance Ability", false, "Transmutation", "Touch" }
                });

            migrationBuilder.InsertData(
                table: "ClassAbilities",
                columns: new[] { "Id", "CharacterClassId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Enter a frenzied state to gain bonus damage, resist physical damage, and advantage on Strength checks/saving throws.", "Rage" },
                    { 2, 1, "Add Constitution modifier to AC when not wearing armor.", "Unarmored Defense" },
                    { 3, 1, "Gain advantage on melee attack rolls, but attacks against you also have advantage.", "Reckless Attack" },
                    { 4, 1, "Gain advantage on Dexterity saving throws against effects you can see.", "Danger Sense" },
                    { 5, 2, "Inspire allies with a bonus to ability checks, attack rolls, or saving throws.", "Bardic Inspiration" },
                    { 6, 2, "Help allies recover additional hit points during short rests.", "Song of Rest" },
                    { 7, 2, "Use a wide variety of spells to charm, inspire, and deal damage.", "Bardic Magic" },
                    { 8, 2, "Add half proficiency bonus to all ability checks you’re not proficient in.", "Jack Of All Trades" },
                    { 9, 3, "Turn undead or perform a special ability depending on your domain.", "Turn Undead" },
                    { 10, 3, "Divine spells drawn from your deity’s domain.", "Divine Intervention" },
                    { 11, 3, "Gain unique abilities based on the chosen divine domain, such as Life, Light, or War.", "DivineDomain" },
                    { 12, 4, "Transform into beasts you’ve seen, gaining their physical traits.", "Wild Shape" },
                    { 13, 4, "Choose a focus for your abilities, such as the Circle of the Land (nature magic) or the Circle of the Moon (enhanced Wild Shape).", "Druidic Circle" },
                    { 14, 4, "Use nature-themed spells to control the environment and heal.", "Spells Of Nature" },
                    { 15, 5, "Recover some hit points as a bonus action.", "Second Wind" },
                    { 16, 5, "Take an additional action on your turn.", "Action Surge" },
                    { 17, 5, "Choose a specialization like Archery or Defense.", "Fighting Style" },
                    { 18, 5, "Gain unique features such as magic use (Eldritch Knight) or commanding allies (Battle Master).", "Martial Archtype" },
                    { 19, 6, "Use Dexterity instead of Strength for unarmed strikes and monk weapons.", "Martial Arts" },
                    { 20, 6, "Perform extraordinary abilities like flurries of blows, increased speed, or stunning strikes.", "Ki Points" },
                    { 21, 6, "Add Wisdom modifier to AC when not wearing armor.", "Unarmored Defense" },
                    { 22, 6, "Reduce damage from ranged weapon attacks.", "DeflectMissles" },
                    { 23, 7, "Heal yourself or others by expending points from a healing pool.", "Lay on Hands" },
                    { 24, 7, " Use spell slots to deal radiant damage on weapon attacks.", "Divine Smite" },
                    { 25, 7, "Add Charisma modifier to saving throws for you and nearby allies.", "Aura Of Protection" },
                    { 26, 7, "Swear an oath like Devotion, Vengeance, or Ancients for unique abilities.", "Sacred Oath" },
                    { 27, 8, "Gain bonuses to tracking and dealing with a specific type of creature.", "Favored Enemy" },
                    { 28, 8, "Gain benefits while traveling through chosen types of terrain.", "Natural Explorer" },
                    { 29, 8, "Use nature magic to aid exploration and combat.", "Ranger Magic" },
                    { 30, 8, "Mark a target to deal extra damage and track it.", "Hunter's Mark" },
                    { 31, 9, "Deal extra damage when you hit with an attack and have advantage or an ally nearby.", "Sneak Attack" },
                    { 32, 9, "Use a bonus action to Dash, Disengage, or Hide.", "Cunning Action" },
                    { 33, 9, "Halve damage from one attack per round.", "UncannyDodge" },
                    { 34, 9, "Avoid all damage on successful Dexterity saves against area effects.", "Evasion" },
                    { 35, 10, "Enhance spells by extending their range, duration, or allowing multiple targets.", "Metamagic" },
                    { 36, 10, " Gain features based on your origin, such as elemental resistance or chaotic magical effects.", "Wild Magic" },
                    { 37, 10, "Use innate magical power to cast spells.", "Sorcery" },
                    { 38, 10, "Fuel unique abilities, such as Metamagic (modifying spells in unique ways).", "SorceryPoints" },
                    { 39, 11, "Use limited spell slots that recharge on short rests.", "Pact Magic" },
                    { 40, 11, "Gain specialized magical abilities, such as improved Eldritch Blast.", "Eldritch Invocations" },
                    { 41, 11, " Choose a boon like a familiar (Pact of the Chain), a weapon (Pact of the Blade), or a magical book (Pact of the Tome).", "Pact Boon" },
                    { 42, 11, "Gain abilities from a pact with an otherworldly entity like the Archfey, Fiend, or Great Old One.", "Patron Features" },
                    { 43, 12, "Regain spell slots during a short rest.", "Arcane Recovery" },
                    { 44, 12, "Access the largest variety of spells in the game.", "Spell Mastery" },
                    { 45, 12, "Choose a school of magic specialization, such as Evocation (damage spells) or Divination (seeing the future).", "Arcane Tradition" },
                    { 46, 12, "Cast certain spells without expending a spell slot.", "Ritual Casting" }
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

            migrationBuilder.InsertData(
                table: "RaceAbility",
                columns: new[] { "Id", "CharacterRaceId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Dark Vision" },
                    { 2, 1, "Resistance to radiant and necrotic damage.", "Celestial Resitance" },
                    { 3, 1, "As an action, touch a creature to restore hit points equal to your level.", "Healing Hands" },
                    { 4, 1, "Gain the light cantrip.", "Light Bearer" },
                    { 5, 2, "Exhale destructive energy in a 15 ft. cone or 30 ft. line (Dex or Con save, depending on ancestry).", "Breath Weapon" },
                    { 6, 2, "Gain resistance to the damage type associated with your draconic ancestry (fire, cold, lightning, etc.).", "Draconic Resistance" },
                    { 7, 3, "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Dark Vision" },
                    { 8, 3, " Advantage on saving throws against poison, and resistance to poison damage.", "Dwarven Resilience" },
                    { 9, 3, "Add double proficiency to Intelligence (History) checks related to stonework.", "Stonecunning" },
                    { 10, 4, "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Dark Vision" },
                    { 11, 4, "Proficiency in Perception.", "Keen Senses" },
                    { 12, 4, "Advantage on saving throws against being charmed, and immunity to magical sleep.", "Fey Ancestry" },
                    { 13, 4, "Elves don’t need sleep. They can finish a long rest in 4 hours while meditating.", "Trance" },
                    { 14, 5, "Cast detect magic and disguise self without expending a spell slot.", "Firbolg Magic" },
                    { 15, 5, "Turn invisible as a bonus action until the start of your next turn.", "Hidden Step" },
                    { 16, 5, "Count as one size larger for carrying capacity.", "Powerful Build" },
                    { 17, 5, "Communicate with animals and plants (they understand you but cannot speak back).", "Speach Of Beast And Leaf" },
                    { 18, 6, "You can hold your breath indefinitely while not incapacitated.", "Unending Breath" },
                    { 19, 6, "You can cast the Levitate spell once with this trait, requiring no material components. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for this spell.", "Mingle with the Wind" },
                    { 20, 7, "You can move across difficult terrain made of earth or stone without expending extra movement.", "Earth Walk" },
                    { 21, 7, "You can cast the Pass Without Trace spell once with this trait, requiring no material components. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for this spell.", "Merge with Stone" },
                    { 22, 8, "You can see in dim light within 60 feet as if it were bright light, and in darkness as if it were dim light. Your vision in darkness is in shades of red.", "Dark Vision" },
                    { 23, 8, "You have resistance to fire damage.", "Fire Resistance" },
                    { 24, 8, "You know the Produce Flame cantrip. Once you reach 3rd level, you can cast the Burning Hands spell once with this trait as a 1st-level spell. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for these spells.", "Reach to the Blaze" },
                    { 25, 9, "You have resistance to acid damage.", "Acid Resistance" },
                    { 26, 9, "You can breathe air and water.", "Amphibious" },
                    { 27, 9, "You know the Shape Water cantrip. Once you reach 3rd level, you can cast the Create or Destroy Water spell once with this trait. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for these spells.", "Call to the Wave" },
                    { 28, 10, "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Dark Vision" },
                    { 29, 10, "Advantage on all Intelligence, Wisdom, and Charisma saving throws against magic.", "Gnome Cunning" },
                    { 30, 11, "Proficiency in Athletics.", "Natual Athlete" },
                    { 31, 11, "Resistance to cold damage and acclimated to high altitudes.", "Mountain Born" },
                    { 32, 11, "Count as one size larger for carrying capacity.", "Powerful Build" },
                    { 33, 11, "Reduce damage taken by 1d12 + Constitution modifier once per short or long rest.", "Stone's Endurance" },
                    { 34, 12, "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Dark Vision" },
                    { 35, 12, "Advantage on saving throws against being charmed, and immunity to magical sleep.", "Fey Ancestry" },
                    { 36, 12, "Gain proficiency in two skills of your choice.", "Skill Versatility" },
                    { 37, 13, " When you roll a 1 on an attack roll, ability check, or saving throw, you can reroll and must use the new roll.", "Lucky" },
                    { 38, 13, "Advantage on saving throws against being frightened.", "Brave" },
                    { 39, 13, "Move through the space of any creature larger than you.", "Halfling Nimbleness" },
                    { 40, 14, "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Relentless Endurance" },
                    { 41, 14, "When reduced to 0 HP but not killed outright, you drop to 1 HP instead (once per long rest).", "Relentless Endurance" },
                    { 42, 14, " When you score a critical hit with a melee weapon, roll one additional damage die.", "Savage Attack" },
                    { 43, 15, "Gain a feat and proficiency in one skill of your choice.\r\n", "Versatile Ability" },
                    { 44, 16, "Mimic sounds you’ve heard, such as voices.", "Mimicry" },
                    { 45, 16, "Duplicate writing and craftwork perfectly.", "Expert Forgery" },
                    { 46, 16, "Proficiency in Deception and Stealth.", "Skill Proficiencies" },
                    { 47, 17, "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Dark Vision" },
                    { 48, 17, "Climb speed of 20 ft. and can deal slashing damage with unarmed strikes.", "Cat’s Claws" },
                    { 49, 17, "Double your movement speed until the end of your turn (requires no movement next turn to reset).", "Feline Agility" },
                    { 50, 18, "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Dark Vision" },
                    { 51, 18, " Resistance to fire damage.", "Infernal Legacy" },
                    { 52, 18, "Gain the thaumaturgy cantrip and spells like hellish rebuke and darkness as you level up.", "Hellish Resistance" },
                    { 53, 19, "As an action, you can withdraw into your shell. While in your shell: Your AC increases by 4.You have advantage on Strength and Constitution saving throws.You are prone, your speed is 0, and you can't take reactions.The only actions you can take are a bonus action to emerge or actions that only affect yourself.", "Shell Defense" },
                    { 54, 19, "You can hold your breath for up to 1 hour, making Tortles excellent at surviving underwater or in environments without air.", "Hold Breath" },
                    { 55, 19, "Your unarmed strikes deal 1d4 slashing damage, thanks to your sharp claws.", "Claws" },
                    { 56, 20, "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Dark Vision" },
                    { 57, 20, "Advantage on saving throws against spells and magical effects.", "Magic Resistance" },
                    { 58, 20, "Immune to poison damage and the poisoned condition.", "Poison Immunity" }
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

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInventory_ItemId",
                table: "CharacterItem",
                column: "ItemId");

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
                name: "IX_CharacterSkills_SkillId",
                table: "CharacterSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSpells_SpellId",
                table: "CharacterSpells",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassAbilities_CharacterClassId",
                table: "ClassAbilities",
                column: "CharacterClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSavingThrows_CharacterClassId",
                table: "ClassSavingThrows",
                column: "CharacterClassId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterItem");

            migrationBuilder.DropTable(
                name: "CharacterSkills");

            migrationBuilder.DropTable(
                name: "CharacterSpells");

            migrationBuilder.DropTable(
                name: "ClassAbilities");

            migrationBuilder.DropTable(
                name: "ClassSavingThrows");

            migrationBuilder.DropTable(
                name: "RaceAbility");

            migrationBuilder.DropTable(
                name: "RaceToolProficiency");

            migrationBuilder.DropTable(
                name: "RaceWeaponProficiency");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "CharacterClasses");

            migrationBuilder.DropTable(
                name: "CharacterRaces");

            migrationBuilder.DropTable(
                name: "IdentityUser<Guid>");
        }
    }
}
