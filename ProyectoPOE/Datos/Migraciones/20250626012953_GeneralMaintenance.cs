using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoPOE.Datos.Migraciones
{
    /// <inheritdoc />
    public partial class GeneralMaintenance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RutaFoto",
                table: "Participantes");

            migrationBuilder.RenameColumn(
                name: "NombresApellidos",
                table: "Participantes",
                newName: "nombres_apellidos");

            migrationBuilder.RenameColumn(
                name: "Cargo",
                table: "Participantes",
                newName: "cargo_funcion");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Participantes",
                newName: "id_participante");

            migrationBuilder.AlterColumn<string>(
                name: "nombres_apellidos",
                table: "Participantes",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cargo_funcion",
                table: "Participantes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<byte[]>(
                name: "foto_participante",
                table: "Participantes",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "foto_participante",
                table: "Participantes");

            migrationBuilder.RenameColumn(
                name: "nombres_apellidos",
                table: "Participantes",
                newName: "NombresApellidos");

            migrationBuilder.RenameColumn(
                name: "cargo_funcion",
                table: "Participantes",
                newName: "Cargo");

            migrationBuilder.RenameColumn(
                name: "id_participante",
                table: "Participantes",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "NombresApellidos",
                table: "Participantes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Cargo",
                table: "Participantes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "RutaFoto",
                table: "Participantes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
