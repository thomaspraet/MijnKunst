using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MijnKunst.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedArtworks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "Id", "ArtistId", "Dimensions", "ImageUrl", "TechnicId", "Title" },
                values: new object[,]
                {
                    { 1, 18, "236 x 206", "", 12, "Geisha Hoerke" },
                    { 2, 9, "195 x 200", "", 27, "De zeven leeftijden van de mens" },
                    { 3, 7, "296 x 207", "", 2, "zonder titel" },
                    { 4, 7, "385 x 290", "", 27, "zonder titel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
