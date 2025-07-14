using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoPOE.Datos.Migraciones
{
    /// <inheritdoc />
    public partial class CreateVotosComentarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comentario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mensaje = table.Column<string>(type: "varchar(100)", nullable: false),
                    idEmprendimiento = table.Column<int>(type: "int", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentario", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comentario_emprendimiento_idEmprendimiento",
                        column: x => x.idEmprendimiento,
                        principalTable: "emprendimiento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comentario_usuario_idUsuario",
                        column: x => x.idUsuario,
                        principalTable: "usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEmprendimiento = table.Column<int>(type: "int", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voto", x => x.id);
                    table.ForeignKey(
                        name: "FK_Voto_emprendimiento_idEmprendimiento",
                        column: x => x.idEmprendimiento,
                        principalTable: "emprendimiento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voto_usuario_idUsuario",
                        column: x => x.idUsuario,
                        principalTable: "usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_idEmprendimiento",
                table: "Comentario",
                column: "idEmprendimiento");

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_idUsuario",
                table: "Comentario",
                column: "idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Voto_idEmprendimiento",
                table: "Voto",
                column: "idEmprendimiento");

            migrationBuilder.CreateIndex(
                name: "IX_Voto_idUsuario",
                table: "Voto",
                column: "idUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentario");

            migrationBuilder.DropTable(
                name: "Voto");
        }
    }
}
