using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfcDataBase.Migrations
{
    public partial class OneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwneruserId",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OwneruserId",
                table: "Orders",
                column: "OwneruserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_OwneruserId",
                table: "Orders",
                column: "OwneruserId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_OwneruserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OwneruserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OwneruserId",
                table: "Orders");
        }
    }
}
