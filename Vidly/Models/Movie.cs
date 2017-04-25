using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        //type prop then tab to create property
        public int Id { get; set; }

        public string Title { get; set; }

        [System.ComponentModel.DisplayName("Released Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        public DateTime AddedDate { get; set; }

        public short NumberOfStock { get; set; }

        public GenreType GenreType { get; set; }

        public short GenreTypeId { get; set; }

    }
}