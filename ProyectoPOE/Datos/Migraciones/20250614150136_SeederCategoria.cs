 using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoPOE.Datos.Migraciones
{
    /// <inheritdoc />
    public partial class SeederCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categoria",
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
                table: "categoria",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categoria",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
