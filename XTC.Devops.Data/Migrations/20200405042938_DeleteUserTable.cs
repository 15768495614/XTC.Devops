using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XTC.Devops.Data.Migrations
{
    public partial class DeleteUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestCases_User_CreatorUserId",
                table: "TestCases");

            migrationBuilder.DropForeignKey(
                name: "FK_TestCases_User_DeleterUserId",
                table: "TestCases");

            migrationBuilder.DropForeignKey(
                name: "FK_TestCases_User_LastModifierUserId",
                table: "TestCases");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_TestCases_CreatorUserId",
                table: "TestCases");

            migrationBuilder.DropIndex(
                name: "IX_TestCases_DeleterUserId",
                table: "TestCases");

            migrationBuilder.DropIndex(
                name: "IX_TestCases_LastModifierUserId",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "TestCases");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "TestCases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "TestCases",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "TestCases",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "TestCases",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TestCases",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "TestCases",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "TestCases",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_CreatorUserId",
                table: "TestCases",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_DeleterUserId",
                table: "TestCases",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_LastModifierUserId",
                table: "TestCases",
                column: "LastModifierUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestCases_User_CreatorUserId",
                table: "TestCases",
                column: "CreatorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestCases_User_DeleterUserId",
                table: "TestCases",
                column: "DeleterUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestCases_User_LastModifierUserId",
                table: "TestCases",
                column: "LastModifierUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
