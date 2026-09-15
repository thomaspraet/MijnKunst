using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MijnKunst.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedArtistIdAndTechnicIdToArtworkTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Artworks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TechnicId",
                table: "Artworks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_ArtistId",
                table: "Artworks",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_TechnicId",
                table: "Artworks",
                column: "TechnicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artworks_Artists_ArtistId",
                table: "Artworks",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artworks_Technics_TechnicId",
                table: "Artworks",
                column: "TechnicId",
                principalTable: "Technics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artworks_Artists_ArtistId",
                table: "Artworks");

            migrationBuilder.DropForeignKey(
                name: "FK_Artworks_Technics_TechnicId",
                table: "Artworks");

            migrationBuilder.DropIndex(
                name: "IX_Artworks_ArtistId",
                table: "Artworks");

            migrationBuilder.DropIndex(
                name: "IX_Artworks_TechnicId",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "TechnicId",
                table: "Artworks");
        }
    }
}
