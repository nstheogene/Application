using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Models
{
    public class Movie:MoviesCategories
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseData { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
    
    
}