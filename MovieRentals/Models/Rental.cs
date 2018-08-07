using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public int MovieId { get; set; }    //FK relationships inferred based on naming convention
        public virtual Movie Movie { get; set; }    //navigation property

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public DateTime RentalDate { get; set; }
    }
}