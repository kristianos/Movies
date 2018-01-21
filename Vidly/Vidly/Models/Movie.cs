using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:D}")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:D}")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1,20, ErrorMessage = "Stock number must be between 1 and 20")]
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }

             
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public short GenreId { get; set; }

    }
}
