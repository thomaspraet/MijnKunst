using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MijnKunst.Models
{
    public class Artwork
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Afmetingen in mm, H x B")]
        public string Dimensions { get; set; } = string.Empty;



        [ValidateNever]
        [Display(Name = "Afbeelding")]
        public string? ImageUrl { get; set; } = string.Empty;
    }
}
