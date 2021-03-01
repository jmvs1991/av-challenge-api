using Microsoft.EntityFrameworkCore.Migrations;

namespace av_challenge_api.Migrations
{
    public partial class agregandoTablaCiudades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CIUDAD",
                columns: table => new
                {
                    ID_CIUDAD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PAIS = table.Column<int>(type: "int", nullable: false),
                    NOMBRE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIUDAD", x => x.ID_CIUDAD);
                });

            migrationBuilder.InsertData(
                table: "CIUDAD",
                columns: new[] { "ID_CIUDAD", "ID_PAIS", "NOMBRE" },
                values: new object[,]
                {
                    { 1, 1, "Buenos Aires" },
                    { 30, 3, "Minas" },
                    { 29, 3, "Mercedes" },
                    { 28, 3, "Artigas" },
                    { 27, 3, "Melo" },
                    { 26, 3, "Tacuarembó" },
                    { 25, 3, "Rivera" },
                    { 24, 3, "Maldonado" },
                    { 23, 3, "Paysandú" },
                    { 22, 3, "Salto" },
                    { 21, 3, "Montevideo" },
                    { 20, 2, "Porto Alegre" },
                    { 19, 2, "Recife" },
                    { 18, 2, "Curitiba" },
                    { 17, 2, "Manaos" },
                    { 16, 2, "Belo Horizonte" },
                    { 15, 2, "Fortaleza" },
                    { 14, 2, "Brasilia" },
                    { 13, 2, "Salvador" },
                    { 12, 2, "Río de Janeiro" },
                    { 11, 2, "Sao Paulo" },
                    { 10, 1, "Resistencia" },
                    { 9, 1, "Bahía Blanca" },
                    { 8, 1, "Corrientes" },
                    { 7, 1, "Santa Fe" },
                    { 6, 1, "Salta" },
                    { 5, 1, "San Miguel de Tucumán" },
                    { 4, 1, "Mar del Plata" },
                    { 3, 1, "Rosario" },
                    { 2, 1, "Córdoba" }
                });

            migrationBuilder.InsertData(
                table: "PAIS",
                columns: new[] { "ID_PAIS", "CODIGO_ISO", "NOMBRE" },
                values: new object[,]
                {
                    { 2, "BR", "Brasil" },
                    { 3, "UY", "Uruguay" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CIUDAD");

            migrationBuilder.DeleteData(
                table: "PAIS",
                keyColumn: "ID_PAIS",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PAIS",
                keyColumn: "ID_PAIS",
                keyValue: 3);
        }
    }
}
