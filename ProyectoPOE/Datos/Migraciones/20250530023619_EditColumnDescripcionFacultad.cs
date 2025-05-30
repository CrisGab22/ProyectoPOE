using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoPOE.Datos.Migraciones
{
    /// <inheritdoc />
    public partial class EditColumnDescripcionFacultad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "facultad",
                newName: "descripcion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "facultad",
                newName: "nombre");
        }
    }
}
