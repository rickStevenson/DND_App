using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DND_App.Web.Migrations.UserDb
{
    /// <inheritdoc />
    public partial class UpdatedIdentitySchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1d65ffd2-ee1e-483c-9f02-9d0f12ff6721", "59c21724-793c-4cb1-9438-dec6213c808b" });

            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "785d5a0a-24a4-40ec-a98b-95e5b4bf43ad", "59c21724-793c-4cb1-9438-dec6213c808b" });

            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd0c279f-d8df-4e39-add7-b33aa79f7cdf", "59c21724-793c-4cb1-9438-dec6213c808b" });

            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d65ffd2-ee1e-483c-9f02-9d0f12ff6721");

            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "785d5a0a-24a4-40ec-a98b-95e5b4bf43ad");

            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd0c279f-d8df-4e39-add7-b33aa79f7cdf");

            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59c21724-793c-4cb1-9438-dec6213c808b");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserTokens",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "UserAuthSchema",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                schema: "UserAuthSchema",
                table: "AspNetUserRoles",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserRoles",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserLogins",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserClaims",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "UserAuthSchema",
                table: "AspNetRoles",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                schema: "UserAuthSchema",
                table: "AspNetRoleClaims",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                schema: "UserAuthSchema",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1d65ffd2-ee1e-483c-9f02-9d0f12ff6721"), "1d65ffd2-ee1e-483c-9f02-9d0f12ff6721", "User", "USER" },
                    { new Guid("785d5a0a-24a4-40ec-a98b-95e5b4bf43ad"), "785d5a0a-24a4-40ec-a98b-95e5b4bf43ad", "Admin", "ADMIN" },
                    { new Guid("bd0c279f-d8df-4e39-add7-b33aa79f7cdf"), "bd0c279f-d8df-4e39-add7-b33aa79f7cdf", "DM", "DM" }
                });

            migrationBuilder.InsertData(
                schema: "UserAuthSchema",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("59c21724-793c-4cb1-9438-dec6213c808b"), 0, "02061711-21c7-40aa-8698-747c259ed0b4", "dadsathome1@gmail.com", false, false, null, "DADSATHOME1@GMAIL.COM", "RICKTHESTICK", "AQAAAAIAAYagAAAAEGwcORNiovEwawMcZakKOOTCRRq4pP8MFta/Se7KbMvANAWqLJIGmWov1B3udoKiSQ==", null, false, null, false, "rickthestick" });

            migrationBuilder.InsertData(
                schema: "UserAuthSchema",
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1d65ffd2-ee1e-483c-9f02-9d0f12ff6721"), new Guid("59c21724-793c-4cb1-9438-dec6213c808b") },
                    { new Guid("785d5a0a-24a4-40ec-a98b-95e5b4bf43ad"), new Guid("59c21724-793c-4cb1-9438-dec6213c808b") },
                    { new Guid("bd0c279f-d8df-4e39-add7-b33aa79f7cdf"), new Guid("59c21724-793c-4cb1-9438-dec6213c808b") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1d65ffd2-ee1e-483c-9f02-9d0f12ff6721"), new Guid("59c21724-793c-4cb1-9438-dec6213c808b") });

            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("785d5a0a-24a4-40ec-a98b-95e5b4bf43ad"), new Guid("59c21724-793c-4cb1-9438-dec6213c808b") });

            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("bd0c279f-d8df-4e39-add7-b33aa79f7cdf"), new Guid("59c21724-793c-4cb1-9438-dec6213c808b") });

            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1d65ffd2-ee1e-483c-9f02-9d0f12ff6721"));

            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("785d5a0a-24a4-40ec-a98b-95e5b4bf43ad"));

            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bd0c279f-d8df-4e39-add7-b33aa79f7cdf"));

            migrationBuilder.DeleteData(
                schema: "UserAuthSchema",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59c21724-793c-4cb1-9438-dec6213c808b"));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                schema: "UserAuthSchema",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                schema: "UserAuthSchema",
                table: "AspNetUserRoles",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserRoles",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserClaims",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                schema: "UserAuthSchema",
                table: "AspNetRoles",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                schema: "UserAuthSchema",
                table: "AspNetRoleClaims",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                schema: "UserAuthSchema",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d65ffd2-ee1e-483c-9f02-9d0f12ff6721", "1d65ffd2-ee1e-483c-9f02-9d0f12ff6721", "User", "User" },
                    { "785d5a0a-24a4-40ec-a98b-95e5b4bf43ad", "785d5a0a-24a4-40ec-a98b-95e5b4bf43ad", "Admin", "Admin" },
                    { "bd0c279f-d8df-4e39-add7-b33aa79f7cdf", "bd0c279f-d8df-4e39-add7-b33aa79f7cdf", "DM", "DM" }
                });

            migrationBuilder.InsertData(
                schema: "UserAuthSchema",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "59c21724-793c-4cb1-9438-dec6213c808b", 0, "e78170ae-760a-4bfb-b74c-d043d945de57", "dadsathome1@gmail.com", false, false, null, "DADSATHOME1@GMAIL.COM", "RICKTHESTICK", "AQAAAAIAAYagAAAAEECi3rHLDiqzmhsRriqPSIgm4yFY0UJ6K3dN3cilXD3wx46rK9yQroh7s4fziMKVkw==", null, false, "43845ac6-8d56-45a2-9507-fe6c62bf1e64", false, "rickthestick" });

            migrationBuilder.InsertData(
                schema: "UserAuthSchema",
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1d65ffd2-ee1e-483c-9f02-9d0f12ff6721", "59c21724-793c-4cb1-9438-dec6213c808b" },
                    { "785d5a0a-24a4-40ec-a98b-95e5b4bf43ad", "59c21724-793c-4cb1-9438-dec6213c808b" },
                    { "bd0c279f-d8df-4e39-add7-b33aa79f7cdf", "59c21724-793c-4cb1-9438-dec6213c808b" }
                });
        }
    }
}
