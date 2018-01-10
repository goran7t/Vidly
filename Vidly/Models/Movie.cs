using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Trla baba lan {0}")]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }
    }    
}