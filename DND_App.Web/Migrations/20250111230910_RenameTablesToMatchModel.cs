using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class RenameTablesToMatchModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(name: "Abilities", newName: "ClassAbilities");
            migrationBuilder.RenameTable(name: "SavingThrows", newName: "ClassSavingThrows");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(name: "ClassAbilities", newName: "Abilities");
            migrationBuilder.RenameTable(name: "ClassSavingThrows", newName: "SavingThrows");
        }
    }
}
