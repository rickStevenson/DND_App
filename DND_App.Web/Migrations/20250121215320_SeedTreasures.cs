using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedTreasures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Treasures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    IsMagical = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treasures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterTreasures",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    TreasureId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTreasures", x => new { x.CharacterId, x.TreasureId });
                    table.ForeignKey(
                        name: "FK_CharacterTreasures_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterTreasures_Treasures_TreasureId",
                        column: x => x.TreasureId,
                        principalTable: "Treasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Treasures",
                columns: new[] { "Id", "Description", "IsMagical", "Name", "Type", "Value", "Weight" },
                values: new object[,]
                {
                    { 1, "A platnum coin.", false, "Platnum Coin", "Coins", 10f, 0.01f },
                    { 2, "A gold coin.", false, "Gold Coin", "Coins", 1f, 0.01f },
                    { 3, "A electrum coin.", false, "Electrum Coin", "Coins", 0.5f, 0.01f },
                    { 4, "A silver coin.", false, "Silver Coin", "Coins", 0.1f, 0.01f },
                    { 5, "A copper coin.", false, "Copper Coin", "Coins", 0.01f, 0.01f },
                    { 6, "A precious clear gem.", false, "Diamond", "Gems", 1000f, 0f },
                    { 7, "A precious blue gem.", false, "Sapphire", "Gems", 500f, 0f },
                    { 8, "A precious green gem.", false, "Emerald", "Gems", 100f, 0f },
                    { 9, "A precious red gem.", false, "Ruby", "Gems", 50f, 0f },
                    { 10, "A beautiful bracelet with delicate ruby inlays.", false, "Silver Bracelet with Ruby Inlays", "Jewelry", 100f, 1f },
                    { 11, "A magical amulet that grants protection to its wearer.", true, "Amulet of Protection", "Artifact", 5000f, 2f },
                    { 12, "A magical sword infused with the essence of valor.", true, "Sword of Valor", "Artifact", 10000f, 10f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTreasures_TreasureId",
                table: "CharacterTreasures",
                column: "TreasureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterTreasures");

            migrationBuilder.DropTable(
                name: "Treasures");
        }
    }
}
