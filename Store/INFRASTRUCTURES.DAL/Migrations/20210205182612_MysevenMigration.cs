using Microsoft.EntityFrameworkCore.Migrations;

namespace INFRASTRUCTURES.DAL.Migrations
{
    public partial class MysevenMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IP",
                table: "logDetails",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IP",
                table: "logDetails");
        }
    }
}
