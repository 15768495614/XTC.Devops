using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XTC.Devops.Data.Migrations
{
    public partial class UpdateAbpEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateByUser",
                table: "TestCases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "TestCases",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatorUserCode",
                table: "TestCases",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteByUser",
                table: "TestCases",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleterUserCode",
                table: "TestCases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "TestCases",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TestCases",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "TestCases",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifierUserCode",
                table: "TestCases",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifyByUser",
                table: "TestCases",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateByUser",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "CreatorUserCode",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "DeleteByUser",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "DeleterUserCode",
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
                name: "LastModifierUserCode",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "LastModifyByUser",
                table: "TestCases");
        }
    }
}
