using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfcDataBase.Migrations
{
    public partial class MoreConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressfirsLine",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddresssecondLine",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressfirsLine_AddresssecondLine",
                table: "Users",
                columns: new[] { "AddressfirsLine", "AddresssecondLine" });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Address_AddressfirsLine_AddresssecondLine",
                table: "Users",
                columns: new[] { "AddressfirsLine", "AddresssecondLine" },
                principalTable: "Address",
                principalColumns: new[] { "firsLine", "secondLine" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Address_AddressfirsLine_AddresssecondLine",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AddressfirsLine_AddresssecondLine",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AddressfirsLine",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AddresssecondLine",
                table: "Users");
        }
    }
}
