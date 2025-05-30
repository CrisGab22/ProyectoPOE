using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoPOE.Datos.Migraciones
{
    /// <inheritdoc />
    public partial class SeedFacultad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "facultad",
                columns: new[] { "id", "descripcion" },
                values: new object[,]
                {
                    { 1, "Facultad de Ciencias Matemáticas y Físicas" },
                    { 2, "Facultad de Ciencias Económicas" },
                    { 3, "Facultad de Ciencias Sociales" },
                    { 4, "Facultad de Derecho" }
                });

            migrationBuilder.InsertData(
                table: "rubro",
                columns: new[] { "id", "descripcion" },
                values: new object[,]
                {
                    { 1, "tecnología" },
                    { 2, "gastronomía" },
                    { 3, "textil" },
                    { 4, "servicios" },
                    { 5, "artesanía" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "facultad",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "facultad",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "facultad",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "facultad",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rubro",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rubro",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rubro",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rubro",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rubro",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
