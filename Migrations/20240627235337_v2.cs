using Microsoft.EntityFrameworkCore.Migrations;

namespace SysVendas2.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Clientes");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Clientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Clientes");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Clientes",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
