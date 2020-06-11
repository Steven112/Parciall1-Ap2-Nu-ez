using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial1_Ap2_Nuñez.Migrations
{
    public partial class PrimerParcial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productos",
                columns: table => new
                {
                    ArticulosId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(maxLength: 200, nullable: false),
                    Existencia = table.Column<int>(nullable: false),
                    Costo = table.Column<decimal>(nullable: false),
                    ValorInventario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos", x => x.ArticulosId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productos");
        }
    }
}
