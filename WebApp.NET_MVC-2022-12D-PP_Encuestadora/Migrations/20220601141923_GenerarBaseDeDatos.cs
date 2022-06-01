using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Migrations
{
    public partial class GenerarBaseDeDatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreCliente = table.Column<string>(nullable: false),
                    mailCliente = table.Column<string>(nullable: false),
                    passwordCliente = table.Column<string>(nullable: true),
                    empresaCliente = table.Column<string>(nullable: true),
                    cuitCliente = table.Column<string>(nullable: true),
                    domicilioCliente = table.Column<string>(nullable: true),
                    precioCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "encuestas",
                columns: table => new
                {
                    EncuestaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tituloEncuesta = table.Column<string>(nullable: false),
                    datetimeCreacionEncuesta = table.Column<DateTime>(nullable: false),
                    datetimeVencimientoEncuesta = table.Column<DateTime>(nullable: false),
                    puntosEncuesta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_encuestas", x => x.EncuestaId);
                });

            migrationBuilder.CreateTable(
                name: "opciones",
                columns: table => new
                {
                    OpcionPreguntaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tituloOpcion = table.Column<string>(nullable: false),
                    opcionSeleccionada = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opciones", x => x.OpcionPreguntaId);
                });

            migrationBuilder.CreateTable(
                name: "preguntas",
                columns: table => new
                {
                    PreguntaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tituloPregunta = table.Column<string>(nullable: false),
                    tipoPregunta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_preguntas", x => x.PreguntaId);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreUsuario = table.Column<string>(nullable: false),
                    mailUsuario = table.Column<string>(nullable: false),
                    passwordUsuario = table.Column<string>(nullable: true),
                    dniUsuario = table.Column<string>(nullable: true),
                    datetimeFechaNacimiento = table.Column<DateTime>(nullable: false),
                    domicilioUsuario = table.Column<string>(nullable: true),
                    preferenciaUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.UsuarioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "encuestas");

            migrationBuilder.DropTable(
                name: "opciones");

            migrationBuilder.DropTable(
                name: "preguntas");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
