using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class ChangedRaceAbilities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RaceAbility",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Dark Vision" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Resistance to radiant and necrotic damage.", "Celestial Resitance" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 1, "As an action, touch a creature to restore hit points equal to your level.", "Healing Hands" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 1, "Gain the light cantrip.", "Light Bearer" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 2, "Exhale destructive energy in a 15 ft. cone or 30 ft. line (Dex or Con save, depending on ancestry).", "Breath Weapon" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 2, "Gain resistance to the damage type associated with your draconic ancestry (fire, cold, lightning, etc.).", "Draconic Resistance" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 3, "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Dark Vision" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 3, " Advantage on saving throws against poison, and resistance to poison damage.", "Dwarven Resilience" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 3, "Add double proficiency to Intelligence (History) checks related to stonework.", "Stonecunning" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 4, "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Dark Vision" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 4, "Proficiency in Perception.", "Keen Senses" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 4, "Advantage on saving throws against being charmed, and immunity to magical sleep.", "Fey Ancestry" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 4, "Elves don’t need sleep. They can finish a long rest in 4 hours while meditating.", "Trance" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 5, "Cast detect magic and disguise self without expending a spell slot.", "Firbolg Magic" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 5, "Turn invisible as a bonus action until the start of your next turn.", "Hidden Step" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 5, "Count as one size larger for carrying capacity.", "Powerful Build" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 5, "Communicate with animals and plants (they understand you but cannot speak back).", "Speach Of Beast And Leaf" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 6, "You can hold your breath indefinitely while not incapacitated.", "Unending Breath" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 6, "You can cast the Levitate spell once with this trait, requiring no material components. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for this spell.", "Mingle with the Wind" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 7, "You can move across difficult terrain made of earth or stone without expending extra movement.", "Earth Walk" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 7, "You can cast the Pass Without Trace spell once with this trait, requiring no material components. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for this spell.", "Merge with Stone" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 8, "You can see in dim light within 60 feet as if it were bright light, and in darkness as if it were dim light. Your vision in darkness is in shades of red.", "Dark Vision" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 8, "You have resistance to fire damage.", "Fire Resistance" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 8, "You know the Produce Flame cantrip. Once you reach 3rd level, you can cast the Burning Hands spell once with this trait as a 1st-level spell. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for these spells.", "Reach to the Blaze" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 9, "You have resistance to acid damage.", "Acid Resistance" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 9, "You can breathe air and water.", "Amphibious" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 9, "You know the Shape Water cantrip. Once you reach 3rd level, you can cast the Create or Destroy Water spell once with this trait. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for these spells.", "Call to the Wave" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 10, "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Dark Vision" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 10, "Advantage on all Intelligence, Wisdom, and Charisma saving throws against magic.", "Gnome Cunning" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 11, "Proficiency in Athletics.", "Natual Athlete" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 11, "Resistance to cold damage and acclimated to high altitudes.", "Mountain Born" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 11, "Count as one size larger for carrying capacity.", "Powerful Build" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 11, "Reduce damage taken by 1d12 + Constitution modifier once per short or long rest.", "Stone's Endurance" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 12, "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", "Dark Vision" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 12, "Advantage on saving throws against being charmed, and immunity to magical sleep.", "Fey Ancestry" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 12, "Gain proficiency in two skills of your choice.", "Skill Versatility" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 13, " When you roll a 1 on an attack roll, ability check, or saving throw, you can reroll and must use the new roll.", "Lucky" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 13, "Advantage on saving throws against being frightened.", "Brave" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CharacterRaceId", "Description", "Name" },
                values: new object[] { 13, "Move through the space of any creature larger than you.", "Halfling Nimbleness" });

            migrationBuilder.InsertData(
                table: "RaceAbility",
                columns: new[] { "Id", "CharacterRaceId", "Description", "Name" },
                values: new object[,]
                {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RaceAbility");

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "DwarvenVision");

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Healing Hands");

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 2, "Breath Weapon" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 2, "Draconic Ancestry" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 3, "DwarvenVision" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 3, "Dwarven Resilience" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 4, "Keen Senses" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 4, "Fey Ancestry" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 5, "Firbolg Magic" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 5, "Hidden Step" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 6, "Unending Breath" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 6, "Mingle with the Wind" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 7, "Earth Walk" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 7, "Merge with Stone" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 8, "DwarvenVision" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 8, "Fire Resistance" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 9, "Acid Resistance" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 9, "ShellDefense" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 10, "Gnome Cunning" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 10, "DwarvenVision" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 11, "Mountain Born" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 11, "Powerful Build" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 12, "DwarvenVision" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 12, "Skill Versatility" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 13, "Lucky" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 13, "Brave" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 14, "Relentless Endurance" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 14, "Savage Attack" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 15, "Versatile Ability" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 16, "Mimicry" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 16, "Expert Forgery" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 17, "Cat’s Claws" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 17, "Feline Agility" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 18, "Infernal Legacy" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 18, "Hellish Resistance" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 19, "Natural Armor" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 19, "Hold Breath" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 20, "Magic Resistance" });

            migrationBuilder.UpdateData(
                table: "RaceAbility",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CharacterRaceId", "Name" },
                values: new object[] { 20, "Poison Immunity" });
        }
    }
}
