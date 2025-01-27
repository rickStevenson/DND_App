using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_App.Web.Migrations.UserDb
{
    /// <inheritdoc />
    public partial class ChangedUserDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the foreign key constraint
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserTokens");

            // Drop the primary key constraint
            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                schema: "UserAuthSchema",
                table: "AspNetUserTokens");

            // Drop any default constraints on UserId
            migrationBuilder.Sql(
                @"DECLARE @constraintName NVARCHAR(256);
          SELECT @constraintName = d.name
          FROM sys.default_constraints d
          INNER JOIN sys.columns c ON d.parent_object_id = c.object_id AND d.parent_column_id = c.column_id
          WHERE c.name = 'UserId' AND c.object_id = OBJECT_ID('UserAuthSchema.AspNetUserTokens');
          IF @constraintName IS NOT NULL EXEC('ALTER TABLE UserAuthSchema.AspNetUserTokens DROP CONSTRAINT [' + @constraintName + ']');");

            // Alter the UserId column to uniqueidentifier
            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            // Recreate the primary key constraint
            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                schema: "UserAuthSchema",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            // Recreate the foreign key constraint
            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserTokens",
                column: "UserId",
                principalSchema: "UserAuthSchema",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the foreign key constraint
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserTokens");

            // Drop the primary key constraint
            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                schema: "UserAuthSchema",
                table: "AspNetUserTokens");

            // Drop any default constraints on UserId
            migrationBuilder.Sql(
                @"DECLARE @constraintName NVARCHAR(256);
          SELECT @constraintName = d.name
          FROM sys.default_constraints d
          INNER JOIN sys.columns c ON d.parent_object_id = c.object_id AND d.parent_column_id = c.column_id
          WHERE c.name = 'UserId' AND c.object_id = OBJECT_ID('UserAuthSchema.AspNetUserTokens');
          IF @constraintName IS NOT NULL EXEC('ALTER TABLE UserAuthSchema.AspNetUserTokens DROP CONSTRAINT [' + @constraintName + ']');");

            // Revert the UserId column to nvarchar(450)
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid));

            // Recreate the original primary key constraint
            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                schema: "UserAuthSchema",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            // Recreate the original foreign key constraint
            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                schema: "UserAuthSchema",
                table: "AspNetUserTokens",
                column: "UserId",
                principalSchema: "UserAuthSchema",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }


    }
}
