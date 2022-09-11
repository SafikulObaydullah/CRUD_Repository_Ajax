using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_Repository_Ajax.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_ProductID",
                table: "SalesDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_SalesMasterID",
                table: "SalesDetails",
                column: "SalesMasterID");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesDetails_Products_ProductID",
                table: "SalesDetails",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesDetails_SalesMasters_SalesMasterID",
                table: "SalesDetails",
                column: "SalesMasterID",
                principalTable: "SalesMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesDetails_Products_ProductID",
                table: "SalesDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesDetails_SalesMasters_SalesMasterID",
                table: "SalesDetails");

            migrationBuilder.DropIndex(
                name: "IX_SalesDetails_ProductID",
                table: "SalesDetails");

            migrationBuilder.DropIndex(
                name: "IX_SalesDetails_SalesMasterID",
                table: "SalesDetails");
        }
    }
}
