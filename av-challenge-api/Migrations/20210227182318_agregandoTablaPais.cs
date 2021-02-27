using Microsoft.EntityFrameworkCore.Migrations;

namespace av_challenge_api.Migrations
{
    public partial class agregandoTablaPais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PAIS",
                columns: table => new
                {
                    ID_PAIS = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CODIGO_ISO = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAIS", x => x.ID_PAIS);
                });

            migrationBuilder.InsertData(
                table: "PAIS",
                columns: new[] { "ID_PAIS", "CODIGO_ISO", "NOMBRE" },
                values: new object[] { 1, "AR", "Argentina" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "ID_USUARIO",
                keyValue: 1,
                column: "USUARIO",
                value: "americavirtual@gmail.com");

            migrationBuilder.CreateIndex(
                name: "IX_PAIS_CODIGO_ISO",
                table: "PAIS",
                column: "CODIGO_ISO",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PAIS");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "ID_USUARIO",
                keyValue: 1,
                column: "USUARIO",
                value: "AVCHALLENGE");
        }
    }
}
