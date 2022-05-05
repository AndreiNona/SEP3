using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfcDataBase.Migrations
{
    public partial class Expanded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "item",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "lenght",
                table: "Products",
                newName: "length");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "orderId",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "url",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_orderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_orderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "orderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "url",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "length",
                table: "Products",
                newName: "lenght");

            migrationBuilder.AddColumn<string>(
                name: "item",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
