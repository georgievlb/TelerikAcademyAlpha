using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstProject.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        public Genre Genre { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public int NumberInStock { get; set; }

        // /movies/random -> location of page, so we need to create a controller called "MoviesController"
        // with an action called "random"
    }
}