using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstProject.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // /movies/random -> location of page, so we need to create a controller called "MoviesController"
        // with an action called "random"
    }
}