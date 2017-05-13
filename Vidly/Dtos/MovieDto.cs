using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime AddedDate { get; set; }

        public byte NumberOfStock { get; set; }

        public byte GenreTypeId { get; set; }

        public GenreTypeDto GenreType { get; set; }
    }
}