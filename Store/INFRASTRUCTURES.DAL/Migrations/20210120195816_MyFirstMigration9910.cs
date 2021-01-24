using Microsoft.EntityFrameworkCore.Migrations;

namespace INFRASTRUCTURES.DAL.Migrations
{
    public partial class MyFirstMigration9910 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productSingleImageCores");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "count",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "isShow",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "count",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isShow",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "productSingleImageCores",
                columns: table => new
                {
                    productSingleImageCoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    mainImages = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productSingleImageCores", x => x.productSingleImageCoreID);
                });
        }
    }
}
