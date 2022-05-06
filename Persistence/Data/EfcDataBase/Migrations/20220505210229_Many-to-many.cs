using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfcDataBase.Migrations
{
    public partial class Manytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_orderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_orderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "orderId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    _ordersorderId = table.Column<int>(type: "INTEGER", nullable: false),
                    _productsproductId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x._ordersorderId, x._productsproductId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders__ordersorderId",
                        column: x => x._ordersorderId,
                        principalTable: "Orders",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products__productsproductId",
                        column: x => x._productsproductId,
                        principalTable: "Products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct__productsproductId",
                table: "OrderProduct",
                column: "_productsproductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.AddColumn<int>(
                name: "orderId",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_orderId",
                table: "Products",
                column: "orderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_orderId",
                table: "Products",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "orderId");
        }
    }
}
