using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedSkills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Alignment",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "HitPoints_Current",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HitPoints_Total",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Initiative",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                    { 17, "Charisma", "Covers entertaining others through music, dance, or acting.", "Perception" },
                    { 18, "Charisma", "Covers influencing others with tact and social grace.", "Persuasion" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkills_SkillId",
                table: "CharacterSkills",
                column: "SkillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterSkills");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "HitPoints_Current",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "HitPoints_Total",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Initiative",
                table: "Characters");

            migrationBuilder.AlterColumn<string>(
                name: "Alignment",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
