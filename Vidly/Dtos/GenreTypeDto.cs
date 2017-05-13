using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    // Created for Web API to get the name of the GenreType, it will create a child json object in the Movies json object.
    // Map it to GenreType as source in the MappingProfile.cs.
    // This class is implemented in the MovieDto model as data type.
    public class GenreTypeDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
    }
}