﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class CustomerSearchViewModel
    {
        public string SearchText { get; set; }
        public List<Customer> Results { get; set; }
    }
}