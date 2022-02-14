using Microsoft.EntityFrameworkCore.Migrations;

namespace iMaxisTienda.Migrations
{
    public partial class InicialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "d",
                table: "tblImaxi");

            migrationBuilder.AddColumn<string>(
                name: "Monto",
                table: "tblImaxi",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Monto",
                table: "tblImaxi");

            migrationBuilder.AddColumn<string>(
                name: "d",
                table: "tblImaxi",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
