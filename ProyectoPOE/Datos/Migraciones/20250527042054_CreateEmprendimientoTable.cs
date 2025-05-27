using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoPOE.Datos.Migraciones
{
    /// <inheritdoc />
    public partial class CreateEmprendimientoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "facultad",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facultad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rubro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rubro", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "emprendimiento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    facultadId = table.Column<int>(type: "int", nullable: false),
                    rubroId = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(500)", nullable: false),
                    foto = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emprendimiento", x => x.id);
                    table.ForeignKey(
                        name: "FK_emprendimiento_facultad_facultadId",
                        column: x => x.facultadId,
                        principalTable: "facultad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_emprendimiento_rubro_rubroId",
                        column: x => x.rubroId,
                        principalTable: "rubro",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_emprendimiento_facultadId",
                table: "emprendimiento",
                column: "facultadId");

            migrationBuilder.CreateIndex(
                name: "IX_emprendimiento_rubroId",
                table: "emprendimiento",
                column: "rubroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emprendimiento");

            migrationBuilder.DropTable(
                name: "facultad");

            migrationBuilder.DropTable(
                name: "rubro");
        }
    }
}
