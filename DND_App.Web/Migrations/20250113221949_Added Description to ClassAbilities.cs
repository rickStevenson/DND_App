using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedDescriptiontoClassAbilities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ClassAbilities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "FeatureAndTrait",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 2,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 3,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 4,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 5,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 6,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 7,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 8,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 9,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 10,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 11,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 12,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 13,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 14,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 15,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 16,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 17,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 18,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 19,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 20,
                column: "FeaturesAndTraitsJson",
                value: "[\r\n  {\r\n    \"name\": \"Lay on Hands\",\r\n    \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n  },\r\n  {\r\n    \"name\": \"Divine Smite\",\r\n    \"description\": \"Harness divine energy to deal additional radiant damage.\"\r\n  }\r\n]\r\n\r\n");

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Enter a frenzied state to gain bonus damage, resist physical damage, and advantage on Strength checks/saving throws.");

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Add Constitution modifier to AC when not wearing armor.");

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 1, "Gain advantage on melee attack rolls, but attacks against you also have advantage.", "Reckless Attack" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 1, "Gain advantage on Dexterity saving throws against effects you can see.", "Danger Sense" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 2, "Inspire allies with a bonus to ability checks, attack rolls, or saving throws.", "Bardic Inspiration" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 2, "Help allies recover additional hit points during short rests.", "Song of Rest" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 2, "Use a wide variety of spells to charm, inspire, and deal damage.", "Bardic Magic" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 2, "Add half proficiency bonus to all ability checks you’re not proficient in.", "Jack Of All Trades" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 3, "Turn undead or perform a special ability depending on your domain.", "Turn Undead" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 3, "Divine spells drawn from your deity’s domain.", "Divine Intervention" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 3, "Gain unique abilities based on the chosen divine domain, such as Life, Light, or War.", "DivineDomain" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 4, "Transform into beasts you’ve seen, gaining their physical traits.", "Wild Shape" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 4, "Choose a focus for your abilities, such as the Circle of the Land (nature magic) or the Circle of the Moon (enhanced Wild Shape).", "Druidic Circle" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 4, "Use nature-themed spells to control the environment and heal.", "Spells Of Nature" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 5, "Recover some hit points as a bonus action.", "Second Wind" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 5, "Take an additional action on your turn.", "Action Surge" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 5, "Choose a specialization like Archery or Defense.", "Fighting Style" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 5, "Gain unique features such as magic use (Eldritch Knight) or commanding allies (Battle Master).", "Martial Archtype" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 6, "Use Dexterity instead of Strength for unarmed strikes and monk weapons.", "Martial Arts" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 6, "Perform extraordinary abilities like flurries of blows, increased speed, or stunning strikes.", "Ki Points" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 6, "Add Wisdom modifier to AC when not wearing armor.", "Unarmored Defense" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 6, "Reduce damage from ranged weapon attacks.", "DeflectMissles" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 7, "Heal yourself or others by expending points from a healing pool.", "Lay on Hands" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CharacterClassId", "Description", "Name" },
                values: new object[] { 7, " Use spell slots to deal radiant damage on weapon attacks.", "Divine Smite" });

            migrationBuilder.InsertData(
                table: "ClassAbilities",
                columns: new[] { "Id", "CharacterClassId", "Description", "Name" },
                values: new object[,]
                {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeatureAndTrait");

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ClassAbilities");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 2,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 3,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 4,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 5,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 6,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 7,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 8,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 9,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 10,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 11,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 12,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 13,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 14,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 15,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 16,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 17,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 18,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 19,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "CharacterRaces",
                keyColumn: "Id",
                keyValue: 20,
                column: "FeaturesAndTraitsJson",
                value: "{\r\n  \"featuresAndTraits\": [\r\n    {\r\n      \"name\": \"DwarvenVision\",\r\n      \"description\": \"Can see in darkness up to 60 feet as if it were dim light.\"\r\n    },\r\n    {\r\n      \"name\": \"Fey Ancestry\",\r\n      \"description\": \"Advantage on saving throws against being charmed, and magic can�t put you to sleep.\"\r\n    },\r\n    {\r\n      \"name\": \"Lay on Hands\",\r\n      \"description\": \"Can heal wounds up to a total amount equal to five times your paladin level.\"\r\n    }\r\n  ]\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 2, "Bardic Inspiration" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 2, "Song of Rest" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 3, "Turn Undead" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 3, "Divine Intervention" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 4, "Wild Shape" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 4, "DruidicCircle" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 5, "Second Wind" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 5, "Action Surge" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 6, "Martial Arts" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 6, "Ki Points" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 7, "Lay on Hands" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 7, "Divine Smite" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 8, "Favored Enemy" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 8, "Natural Explorer" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 9, "Sneak Attack" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 9, "Cunning Action" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 10, "Metamagic" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 10, "Font of Magic" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 11, "Eldritch Invocations" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 11, "Pact Magic" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 12, "Arcane Recovery" });

            migrationBuilder.UpdateData(
                table: "ClassAbilities",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CharacterClassId", "Name" },
                values: new object[] { 12, "Spell Mastery" });
        }
    }
}
