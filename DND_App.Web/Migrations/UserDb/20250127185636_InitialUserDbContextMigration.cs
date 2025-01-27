using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_App.Web.Migrations.UserDb
{
    /// <inheritdoc />
    public partial class InitialUserDbContextMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "UserAuthSchema");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "AspNetUserTokens",
                newSchema: "UserAuthSchema");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "AspNetUsers",
                newSchema: "UserAuthSchema");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "AspNetUserRoles",
                newSchema: "UserAuthSchema");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "AspNetUserLogins",
                newSchema: "UserAuthSchema");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "AspNetUserClaims",
                newSchema: "UserAuthSchema");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "AspNetRoles",
                newSchema: "UserAuthSchema");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "AspNetRoleClaims",
                newSchema: "UserAuthSchema");

            migrationBuilder.UpdateData(
                schema: "UserAuthSchema",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59c21724-793c-4cb1-9438-dec6213c808b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e78170ae-760a-4bfb-b74c-d043d945de57", "AQAAAAIAAYagAAAAEECi3rHLDiqzmhsRriqPSIgm4yFY0UJ6K3dN3cilXD3wx46rK9yQroh7s4fziMKVkw==", "43845ac6-8d56-45a2-9507-fe6c62bf1e64" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "UserAuthSchema",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "UserAuthSchema",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "UserAuthSchema",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "UserAuthSchema",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "UserAuthSchema",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "UserAuthSchema",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "UserAuthSchema",
                newName: "AspNetRoleClaims");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59c21724-793c-4cb1-9438-dec6213c808b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bc43b72-926d-4df7-b03f-92ea12e57116", "AQAAAAIAAYagAAAAEM7POi7+7gG7aR1Zr8MdCi6AhVNX4JFGmPQANXJsy6UZvgeURADQBMFf5/XkFaO2Bg==", "0fa8422c-3eab-4390-ac23-d7e88c7645ae" });
        }
    }
}
