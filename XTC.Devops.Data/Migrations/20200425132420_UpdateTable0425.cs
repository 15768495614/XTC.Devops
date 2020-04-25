using Microsoft.EntityFrameworkCore.Migrations;

namespace XTC.Devops.Data.Migrations
{
    public partial class UpdateTable0425 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerCode",
                table: "Project",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "Project",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerCode",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "Project");
        }
    }
}
