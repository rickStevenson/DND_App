using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class TempFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterItems_Characters_CharacterId",
                table: "CharacterItems");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterItems_Characters_CharacterId",
                table: "CharacterItems",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterItems_Characters_CharacterId",
                table: "CharacterItems");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterItems_Characters_CharacterId",
                table: "CharacterItems",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
