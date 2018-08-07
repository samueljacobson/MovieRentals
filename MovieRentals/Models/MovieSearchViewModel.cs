using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class MovieSearchViewModel
    {
        public string SearchText { get; set; }
        public List<Movie> Results { get; set; }
    }
}