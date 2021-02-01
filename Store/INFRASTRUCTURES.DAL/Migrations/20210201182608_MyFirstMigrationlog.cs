using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace INFRASTRUCTURES.DAL.Migrations
{
    public partial class MyFirstMigrationlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "logDetails",
                columns: table => new
                {
                    LogDetailsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productID = table.Column<int>(type: "int", nullable: false),
                    VisitTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logDetails", x => x.LogDetailsID);
                    table.ForeignKey(
                        name: "FK_logDetails_Products_productID",
                        column: x => x.productID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "logMasters",
                columns: table => new
                {
                    LogMasterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productID = table.Column<int>(type: "int", nullable: false),
                    CountVisit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logMasters", x => x.LogMasterID);
                    table.ForeignKey(
                        name: "FK_logMasters_Products_productID",
                        column: x => x.productID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_logDetails_productID",
                table: "logDetails",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_logMasters_productID",
                table: "logMasters",
                column: "productID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logDetails");

            migrationBuilder.DropTable(
                name: "logMasters");
        }
    }
}
