using Microsoft.EntityFrameworkCore.Migrations;

namespace TiendaLibrito.Migrations
{
    public partial class AgregandoPrecioLibro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Libros",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Libros");
        }
    }
}
