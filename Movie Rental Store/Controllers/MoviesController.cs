using Movie_Rental_Store.Models;
using Movie_Rental_Store.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie_Rental_Store.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movie = new List<Movie>
            {
                new Movie{Id = 1 ,Name = "Shrek" },
                new Movie{Id = 2, Name = "Wall-E"}
            };

           
            return View(movie);
        }
    }
}