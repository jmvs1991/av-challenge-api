using Microsoft.EntityFrameworkCore.Migrations;

namespace av_challenge_api.Migrations
{
    public partial class ajustandoNombreTablaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "USUARIO");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_USUARIO",
                table: "USUARIO",
                newName: "IX_USUARIO_USUARIO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_USUARIO",
                table: "USUARIO",
                column: "ID_USUARIO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_USUARIO",
                table: "USUARIO");

            migrationBuilder.RenameTable(
                name: "USUARIO",
                newName: "Usuario");

            migrationBuilder.RenameIndex(
                name: "IX_USUARIO_USUARIO",
                table: "Usuario",
                newName: "IX_Usuario_USUARIO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "ID_USUARIO");
        }
    }
}
