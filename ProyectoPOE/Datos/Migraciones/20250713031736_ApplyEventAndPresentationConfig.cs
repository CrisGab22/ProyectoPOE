using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoPOE.Datos.Migraciones
{
    /// <inheritdoc />
    public partial class ApplyEventAndPresentationConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    id_evento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_evento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fecha_evento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ubicacion_evento = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.id_evento);
                });

            migrationBuilder.CreateTable(
                name: "Presentacion",
                columns: table => new
                {
                    id_presentacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orden = table.Column<int>(type: "int", nullable: false),
                    tema_presentacion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    hora_inicio = table.Column<TimeSpan>(type: "time", nullable: false),
                    duracion_minutos = table.Column<int>(type: "int", nullable: false),
                    id_evento = table.Column<int>(type: "int", nullable: false),
                    id_emprendimiento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presentacion", x => x.id_presentacion);
                    table.ForeignKey(
                        name: "FK_Presentacion_Evento_id_evento",
                        column: x => x.id_evento,
                        principalTable: "Evento",
                        principalColumn: "id_evento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presentacion_emprendimiento_id_emprendimiento",
                        column: x => x.id_emprendimiento,
                        principalTable: "emprendimiento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Evento",
                columns: new[] { "id_evento", "fecha_evento", "nombre_evento", "ubicacion_evento" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feria de Innovación 2025", "Centro de Convenciones" },
                    { 2, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Expo Emprendedores Juveniles", "Auditorio Principal" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Presentacion_id_emprendimiento",
                table: "Presentacion",
                column: "id_emprendimiento");

            migrationBuilder.CreateIndex(
                name: "IX_Presentacion_id_evento",
                table: "Presentacion",
                column: "id_evento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presentacion");

            migrationBuilder.DropTable(
                name: "Evento");
        }
    }
}
