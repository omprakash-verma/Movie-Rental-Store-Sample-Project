using Movie_Rental_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Rental_Store.ViewModels
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}