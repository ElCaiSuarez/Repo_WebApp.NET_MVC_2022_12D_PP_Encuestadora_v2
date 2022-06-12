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
                    nombreCliente = table.Column<string>(maxLength: 80, nullable: false),
                    mailCliente = table.Column<string>(maxLength: 40, nullable: false),
                    passwordCliente = table.Column<string>(maxLength: 10, nullable: false),
                    empresaCliente = table.Column<string>(maxLength: 40, nullable: true),
                    cuitCliente = table.Column<string>(maxLength: 11, nullable: true),
                    domicilioCliente = table.Column<string>(maxLength: 40, nullable: true),
                    precioCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreUsuario = table.Column<string>(maxLength: 80, nullable: false),
                    mailUsuario = table.Column<string>(maxLength: 40, nullable: false),
                    passwordUsuario = table.Column<string>(maxLength: 10, nullable: false),
                    dniUsuario = table.Column<string>(maxLength: 8, nullable: false),
                    datetimeFechaNacimiento = table.Column<DateTime>(nullable: false),
                    domicilioUsuario = table.Column<string>(maxLength: 40, nullable: true),
                    preferenciaUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "encuestas",
                columns: table => new
                {
                    EncuestaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tituloEncuesta = table.Column<string>(maxLength: 40, nullable: false),
                    datetimeCreacionEncuesta = table.Column<DateTime>(nullable: false),
                    datetimeVencimientoEncuesta = table.Column<DateTime>(nullable: false),
                    puntosEncuesta = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_encuestas", x => x.EncuestaId);
                    table.ForeignKey(
                        name: "FK_encuestas_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EncuestaRespondida",
                columns: table => new
                {
                    EncuestaRespondidaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EncuestaId = table.Column<int>(nullable: false),
                    tituloEncuesta = table.Column<string>(maxLength: 40, nullable: false),
                    datetimeCreacionEncuesta = table.Column<DateTime>(nullable: false),
                    puntosEncuesta = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncuestaRespondida", x => x.EncuestaRespondidaId);
                    table.ForeignKey(
                        name: "FK_EncuestaRespondida_encuestas_EncuestaId",
                        column: x => x.EncuestaId,
                        principalTable: "encuestas",
                        principalColumn: "EncuestaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EncuestaRespondida_usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "preguntas",
                columns: table => new
                {
                    PreguntaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tituloPregunta = table.Column<string>(maxLength: 40, nullable: false),
                    tipoPregunta = table.Column<int>(nullable: false),
                    EncuestaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_preguntas", x => x.PreguntaId);
                    table.ForeignKey(
                        name: "FK_preguntas_encuestas_EncuestaId",
                        column: x => x.EncuestaId,
                        principalTable: "encuestas",
                        principalColumn: "EncuestaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "opciones",
                columns: table => new
                {
                    OpcionPreguntaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tituloOpcion = table.Column<string>(maxLength: 40, nullable: false),
                    opcionSeleccionada = table.Column<bool>(nullable: false),
                    PreguntaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opciones", x => x.OpcionPreguntaId);
                    table.ForeignKey(
                        name: "FK_opciones_preguntas_PreguntaId",
                        column: x => x.PreguntaId,
                        principalTable: "preguntas",
                        principalColumn: "PreguntaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "respuestas",
                columns: table => new
                {
                    PreguntaRespondidaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreguntaId = table.Column<int>(nullable: false),
                    Respuesta = table.Column<string>(nullable: true),
                    EncuestaRespondidaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_respuestas", x => x.PreguntaRespondidaId);
                    table.ForeignKey(
                        name: "FK_respuestas_EncuestaRespondida_EncuestaRespondidaId",
                        column: x => x.EncuestaRespondidaId,
                        principalTable: "EncuestaRespondida",
                        principalColumn: "EncuestaRespondidaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_respuestas_preguntas_PreguntaId",
                        column: x => x.PreguntaId,
                        principalTable: "preguntas",
                        principalColumn: "PreguntaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EncuestaRespondida_EncuestaId",
                table: "EncuestaRespondida",
                column: "EncuestaId");

            migrationBuilder.CreateIndex(
                name: "IX_EncuestaRespondida_UsuarioId",
                table: "EncuestaRespondida",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_encuestas_ClienteId",
                table: "encuestas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_opciones_PreguntaId",
                table: "opciones",
                column: "PreguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_preguntas_EncuestaId",
                table: "preguntas",
                column: "EncuestaId");

            migrationBuilder.CreateIndex(
                name: "IX_respuestas_EncuestaRespondidaId",
                table: "respuestas",
                column: "EncuestaRespondidaId");

            migrationBuilder.CreateIndex(
                name: "IX_respuestas_PreguntaId",
                table: "respuestas",
                column: "PreguntaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "opciones");

            migrationBuilder.DropTable(
                name: "respuestas");

            migrationBuilder.DropTable(
                name: "EncuestaRespondida");

            migrationBuilder.DropTable(
                name: "preguntas");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "encuestas");

            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
