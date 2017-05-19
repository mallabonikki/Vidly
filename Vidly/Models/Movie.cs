using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        //type prop then tab to create property
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime AddedDate { get; set; }

        [Display(Name = "Number Of Stock")]
        public byte NumberOfStock { get; set; }

        public GenreType GenreType { get; set; }

        [Display(Name = "Genre Type")]
        [Required]
        public byte GenreTypeId { get; set; }

        public byte NumberAvailable { get; set; }

    }
}