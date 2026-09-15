using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MijnKunst.Models;

namespace MijnKunst.web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Technic> Technics { get; set; }
        public DbSet<Artwork> Artworks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Artist>().HasData(
                new Artist { Id = 1, FirstName = "Nancy", LastName = "Bailleux", PlaceOfBirth = "Antwerpen", YearOfBirth = "1964" },
                new Artist { Id = 2, LastName = "Banksy", PlaceOfBirth = "Yate (UK)", YearOfBirth = "1974" },
                new Artist { Id = 3, FirstName = "Gerrit", LastName = "Baten", PlaceOfBirth = "Aalst", YearOfBirth = "1959" },
                new Artist { Id = 4, FirstName = "Etienne", LastName = "Bauwens", PlaceOfBirth = "Aalst", YearOfBirth = "1930" },
                new Artist { Id = 5, FirstName = "Geert", LastName = "Bauwens", PlaceOfBirth = "Aalst", YearOfBirth = "1961" },
                new Artist { Id = 6, FirstName = "René", LastName = "Bekaert", PlaceOfBirth = "Aalst", YearOfBirth = "1938" },
                new Artist { Id = 7, FirstName = "André", LastName = "Berner", PlaceOfBirth = "Vilvoorde", YearOfBirth = "1955" },
                new Artist { Id = 8, FirstName = "Walter", LastName = "Brems", PlaceOfBirth = "Reet", YearOfBirth = "1947" },
                new Artist { Id = 9, FirstName = "Pedro", LastName = "Brugada", PlaceOfBirth = "Girona (ESP)", YearOfBirth = "1952" },
                new Artist { Id = 10, FirstName = "André", LastName = "Bruylandt", PlaceOfBirth = "Onkerzele", YearOfBirth = "1944" },
                new Artist { Id = 11, FirstName = "Roland", LastName = "Cobbaut", PlaceOfBirth = "", YearOfBirth = "" },
                new Artist { Id = 12, FirstName = "Claire", LastName = "Cocquyt", PlaceOfBirth = "", YearOfBirth = "" },
                new Artist { Id = 13, FirstName = "", LastName = "Expha", PlaceOfBirth = "Gent", YearOfBirth = "" },
                new Artist { Id = 14, FirstName = "Carla", LastName = "Heuvinck", PlaceOfBirth = "", YearOfBirth = "" },
                new Artist { Id = 15, FirstName = "", LastName = "MarieAnge", PlaceOfBirth = "Nieuwpoort", YearOfBirth = "1963" },
                new Artist { Id = 16, FirstName = "Martina", LastName = "Mory", PlaceOfBirth = "", YearOfBirth = "" },
                new Artist { Id = 17, FirstName = "Jacky", LastName = "Zegers", PlaceOfBirth = "", YearOfBirth = "" },
                new Artist { Id = 18, FirstName = "Pieter", LastName = "De Poortere", PlaceOfBirth = "Gent", YearOfBirth = "1976" }

            );



            modelBuilder.Entity<Artwork>().HasData(
                new Artwork
                {
                    Id = 1,
                    Title = "Geisha Hoerke",
                    Dimensions = "236 x 206",
                    ImageUrl = "",
                    ArtistId = 18,
                    TechnicId = 12


                },
                new Artwork
                {
                    Id = 2,
                    Title = "De zeven leeftijden van de mens",
                    Dimensions = "195 x 200",
                    ImageUrl = "",
                    ArtistId = 9,
                    TechnicId = 27


                },
                new Artwork
                {
                    Id = 3,
                    Title = "zonder titel",
                    Dimensions = "296 x 207",
                    ImageUrl = "",
                    ArtistId = 7,
                    TechnicId = 2


                },
                new Artwork
                {
                    Id = 4,
                    Title = "zonder titel",
                    Dimensions = "385 x 290",
                    ImageUrl = "",
                    ArtistId = 7,
                    TechnicId = 27

                }

            );

            modelBuilder.Entity<Technic>().HasData(
                new Technic { Id =  1, Name = "Acryl" },
                new Technic { Id =  2, Name = "Aquarel" },
                new Technic { Id =  3, Name = "Aquarel & fineliner" },
                new Technic { Id =  4, Name = "Aquatint" },
                new Technic { Id =  5, Name = "Bister" },
                new Technic { Id =  6, Name = "Balpen & markers" },
                new Technic { Id =  7, Name = "Cement" },
                new Technic { Id =  8, Name = "Ets" },
                new Technic { Id =  9, Name = "Ets, droge naald" },
                new Technic { Id = 10, Name = "Gemengde techniek" },
                new Technic { Id = 11, Name = "Gouache" },
                new Technic { Id = 12, Name = "Houtsnede" },
                new Technic { Id = 13, Name = "Keramiek" },
                new Technic { Id = 14, Name = "Klei" },
                new Technic { Id = 15, Name = "Kleurpotlood" },
                new Technic { Id = 16, Name = "Linosnede" },
                new Technic { Id = 17, Name = "Nagellak" },
                new Technic { Id = 18, Name = "Litho" },
                new Technic { Id = 19, Name = "Offset druk" },
                new Technic { Id = 20, Name = "Olieverf" },
                new Technic { Id = 21, Name = "Oostindische inkt" },
                new Technic { Id = 22, Name = "Opgehoogde zeefdruk" },
                new Technic { Id = 23, Name = "PC grafiek" },
                new Technic { Id = 24, Name = "Print op doek" },
                new Technic { Id = 25, Name = "Print op fotopapier" },
                new Technic { Id = 26, Name = "Resin" },
                new Technic { Id = 27, Name = "Zeefdruk" }

            );
        }
    }
}
