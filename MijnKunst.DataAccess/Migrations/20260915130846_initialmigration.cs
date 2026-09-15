using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MijnKunst.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artworks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechnicId = table.Column<int>(type: "int", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artworks_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artworks_Technics_TechnicId",
                        column: x => x.TechnicId,
                        principalTable: "Technics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "FirstName", "LastName", "PlaceOfBirth", "YearOfBirth" },
                values: new object[,]
                {
                    { 1, "Nancy", "Bailleux", "Antwerpen", "1964" },
                    { 2, "", "Banksy", "Yate (UK)", "1974" },
                    { 3, "Gerrit", "Baten", "Aalst", "1959" },
                    { 4, "Etienne", "Bauwens", "Aalst", "1930" },
                    { 5, "Geert", "Bauwens", "Aalst", "1961" },
                    { 6, "René", "Bekaert", "Aalst", "1938" },
                    { 7, "André", "Berner", "Vilvoorde", "1955" },
                    { 8, "Walter", "Brems", "Reet", "1947" },
                    { 9, "Pedro", "Brugada", "Girona (ESP)", "1952" },
                    { 10, "André", "Bruylandt", "Onkerzele", "1944" },
                    { 11, "Roland", "Cobbaut", "", "" },
                    { 12, "Claire", "Cocquyt", "", "" },
                    { 13, "", "Expha", "Gent", "" },
                    { 14, "Carla", "Heuvinck", "", "" },
                    { 15, "", "MarieAnge", "Nieuwpoort", "1963" },
                    { 16, "Martina", "Mory", "", "" },
                    { 17, "Jacky", "Zegers", "", "" },
                    { 18, "Pieter", "De Poortere", "Gent", "1976" }
                });

            migrationBuilder.InsertData(
                table: "Technics",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Acryl" },
                    { 2, "Aquarel" },
                    { 3, "Aquarel & fineliner" },
                    { 4, "Aquatint" },
                    { 5, "Bister" },
                    { 6, "Balpen & markers" },
                    { 7, "Cement" },
                    { 8, "Ets" },
                    { 9, "Ets, droge naald" },
                    { 10, "Gemengde techniek" },
                    { 11, "Gouache" },
                    { 12, "Houtsnede" },
                    { 13, "Keramiek" },
                    { 14, "Klei" },
                    { 15, "Kleurpotlood" },
                    { 16, "Linosnede" },
                    { 17, "Nagellak" },
                    { 18, "Litho" },
                    { 19, "Offset druk" },
                    { 20, "Olieverf" },
                    { 21, "Oostindische inkt" },
                    { 22, "Opgehoogde zeefdruk" },
                    { 23, "PC grafiek" },
                    { 24, "Print op doek" },
                    { 25, "Print op fotopapier" },
                    { 26, "Resin" },
                    { 27, "Zeefdruk" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_ArtistId",
                table: "Artworks",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_TechnicId",
                table: "Artworks",
                column: "TechnicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artworks");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Technics");
        }
    }
}
