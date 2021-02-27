using Microsoft.EntityFrameworkCore.Migrations;

namespace av_challenge_api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USUARIO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CLAVE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOMBRE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CORREO = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID_USUARIO);
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "ID_USUARIO", "CLAVE", "CORREO", "NOMBRE", "USUARIO" },
                values: new object[] { 1, "challenge2021", "", "José Vásquez", "AVCHALLENGE" });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_USUARIO",
                table: "Usuario",
                column: "USUARIO",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
