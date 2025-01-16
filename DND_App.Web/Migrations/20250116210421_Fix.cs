using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Alignment",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    SpellID = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Spells", x => x.SpellID);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSpells",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    SpellId = table.Column<int>(type: "int", nullable: false),
                    SpellID = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_CharacterSpells_Spells_SpellID",
                        column: x => x.SpellID,
                        principalTable: "Spells",
                        principalColumn: "SpellID");
                    table.ForeignKey(
                        name: "FK_CharacterSpells_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "SpellID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Performance");

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "SpellID", "CastingTime", "Description", "Duration", "IsPrepared", "Level", "Name", "RequiresConcentration", "School", "SpellRange" },
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

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSpells_SpellId",
                table: "CharacterSpells",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSpells_SpellID",
                table: "CharacterSpells",
                column: "SpellID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterSpells");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Alignment",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Perception");
        }
    }
}
