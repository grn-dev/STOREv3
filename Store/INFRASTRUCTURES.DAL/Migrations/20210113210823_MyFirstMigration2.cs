using Microsoft.EntityFrameworkCore.Migrations;

namespace INFRASTRUCTURES.DAL.Migrations
{
    public partial class MyFirstMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_imgeProducts_Products_ProductID",
                table: "imgeProducts");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "imgeProducts",
                newName: "productID");

            migrationBuilder.RenameColumn(
                name: "ImageValueID",
                table: "imgeProducts",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_imgeProducts_ProductID",
                table: "imgeProducts",
                newName: "IX_imgeProducts_productID");

            migrationBuilder.AlterColumn<int>(
                name: "productID",
                table: "imgeProducts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "productSingleImageCores",
                columns: table => new
                {
                    productSingleImageCoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mainImages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productSingleImageCores", x => x.productSingleImageCoreID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_imgeProducts_Products_productID",
                table: "imgeProducts",
                column: "productID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_imgeProducts_Products_productID",
                table: "imgeProducts");

            migrationBuilder.DropTable(
                name: "productSingleImageCores");

            migrationBuilder.RenameColumn(
                name: "productID",
                table: "imgeProducts",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "imgeProducts",
                newName: "ImageValueID");

            migrationBuilder.RenameIndex(
                name: "IX_imgeProducts_productID",
                table: "imgeProducts",
                newName: "IX_imgeProducts_ProductID");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "imgeProducts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_imgeProducts_Products_ProductID",
                table: "imgeProducts",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
