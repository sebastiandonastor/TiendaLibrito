using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TiendaLibrito.Migrations
{
    public partial class AgregandoFactura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetalleFacturas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaExpedicion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleFacturas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    IdLibro = table.Column<int>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    IdDetalleFactura = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    AutorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => new { x.IdCliente, x.IdLibro, x.IdDetalleFactura });
                    table.ForeignKey(
                        name: "FK_Facturas_Autores_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturas_DetalleFacturas_IdDetalleFactura",
                        column: x => x.IdDetalleFactura,
                        principalTable: "DetalleFacturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturas_Libros_IdLibro",
                        column: x => x.IdLibro,
                        principalTable: "Libros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_AutorId",
                table: "Facturas",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_IdDetalleFactura",
                table: "Facturas",
                column: "IdDetalleFactura");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_IdLibro",
                table: "Facturas",
                column: "IdLibro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "DetalleFacturas");
        }
    }
}
