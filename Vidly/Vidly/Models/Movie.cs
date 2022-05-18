using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        //properties
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime AddedDate { get; set; }
        [Required]
        public int NumberInStock { get; set; }
        public Genre Genre { get; set; }
        [Required]
        public int GenreId { get; set; }

        //methods
        //get releaseDate in preset or custom format
        public string ReleaseDateToString(string format = "dddd, d MMMM, yyyy") { return ReleaseDate.ToString(format); }

        //get AddedDate in preset or custom format
        public string AddedDateToString(string format = "dddd, d MMMM, yyyy") { return AddedDate.ToString(format); }

        //rent a movie
        public Movie Rent()
        {
            NumberInStock-=1;
            return this;
        }
    }
}