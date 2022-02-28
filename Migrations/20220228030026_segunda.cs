using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Productos_Detalle.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Costo",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Existencia",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Ganancia",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ValorInventario",
                table: "Productos");

            migrationBuilder.AddColumn<double>(
                name: "Costo",
                table: "ProductosDetalle",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Ganancia",
                table: "ProductosDetalle",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Costo",
                table: "ProductosDetalle");

            migrationBuilder.DropColumn(
                name: "Ganancia",
                table: "ProductosDetalle");

            migrationBuilder.AddColumn<double>(
                name: "Costo",
                table: "Productos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Existencia",
                table: "Productos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Ganancia",
                table: "Productos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Precio",
                table: "Productos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ValorInventario",
                table: "Productos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
