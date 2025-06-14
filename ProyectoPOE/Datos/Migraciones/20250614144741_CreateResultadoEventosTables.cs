using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoPOE.Datos.Migraciones
{
    /// <inheritdoc />
    public partial class CreateResultadoEventosTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombresApellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RutaFoto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "resultadoevento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoriaId = table.Column<int>(type: "int", nullable: false),
                    emprendimientoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resultadoevento", x => x.id);
                    table.ForeignKey(
                        name: "FK_resultadoevento_categoria_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_resultadoevento_emprendimiento_emprendimientoId",
                        column: x => x.emprendimientoId,
                        principalTable: "emprendimiento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_resultadoevento_categoriaId",
                table: "resultadoevento",
                column: "categoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_resultadoevento_emprendimientoId",
                table: "resultadoevento",
                column: "emprendimientoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participantes");

            migrationBuilder.DropTable(
                name: "resultadoevento");

            migrationBuilder.DropTable(
                name: "categoria");
        }
    }
}
