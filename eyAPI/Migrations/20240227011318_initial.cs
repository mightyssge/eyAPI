using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eyAPI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NombreComercial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IdentificacionTributaria = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NumeroTelefonico = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SitioWeb = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DireccionFisica = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FacturacionAnual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaUltimaEdicion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Providers");
        }
    }
}
