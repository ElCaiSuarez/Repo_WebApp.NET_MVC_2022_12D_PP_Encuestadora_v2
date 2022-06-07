using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Migrations
{
    public partial class CrearBaseDeDatos_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "encuestas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "encuestasUsuarios",
                columns: table => new
                {
                    EncuestaId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_encuestasUsuarios", x => new { x.EncuestaId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_encuestasUsuarios_encuestas_EncuestaId",
                        column: x => x.EncuestaId,
                        principalTable: "encuestas",
                        principalColumn: "EncuestaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_encuestasUsuarios_usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_encuestas_ClienteId",
                table: "encuestas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_encuestasUsuarios_UsuarioId",
                table: "encuestasUsuarios",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_encuestas_clientes_ClienteId",
                table: "encuestas",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_encuestas_clientes_ClienteId",
                table: "encuestas");

            migrationBuilder.DropTable(
                name: "encuestasUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_encuestas_ClienteId",
                table: "encuestas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "encuestas");
        }
    }
}
