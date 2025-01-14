using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_App.Web.Migrations
{
    /// <inheritdoc />
    public partial class RemovedFeaturesAndTraits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeatureAndTrait");

            migrationBuilder.DropColumn(
                name: "FeaturesAndTraitsJson",
                table: "CharacterRaces");

            migrationBuilder.DropColumn(
                name: "FeaturesAndTraitsJson",
                table: "CharacterClasses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FeaturesAndTraitsJson",
                table: "CharacterRaces",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeaturesAndTraitsJson",
                table: "CharacterClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "FeatureAndTrait",
                columns: table => new
                {
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
        }
    }
}
