using System.ComponentModel.DataAnnotations;

namespace MijnKunst.Models
{
    public class Artist
    {
        public int Id { get; set; }
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Achternaam")]
        public string LastName { get; set; } = string.Empty;
        [Display(Name = "Geboorteplaats")]
        public string PlaceOfBirth { get; set; } = string.Empty;
        [Display(Name = "Geboortejaar")]
        public string YearOfBirth { get; set; } = string.Empty;
    }
}
