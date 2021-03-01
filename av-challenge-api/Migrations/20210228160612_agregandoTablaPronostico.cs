using Microsoft.EntityFrameworkCore.Migrations;

namespace av_challenge_api.Migrations
{
    public partial class agregandoTablaPronostico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PRONOSTICO",
                columns: table => new
                {
                    ID_PRONOSTICO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CIUDAD = table.Column<int>(type: "int", nullable: false),
                    FECHA = table.Column<long>(type: "bigint", nullable: false),
                    TEMPERATURA = table.Column<int>(type: "int", nullable: false),
                    ESTADO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRECIPITACION = table.Column<int>(type: "int", nullable: false),
                    HUMEDAD = table.Column<int>(type: "int", nullable: false),
                    VIENTO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRONOSTICO", x => x.ID_PRONOSTICO);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRONOSTICO_FECHA_ID_CIUDAD",
                table: "PRONOSTICO",
                columns: new[] { "FECHA", "ID_CIUDAD" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRONOSTICO");
        }
    }
}
