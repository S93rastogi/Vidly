using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customer1 = new Customer
            {
                Name="Customer1"
            };
            var customer2 = new Customer
            {
                Name = "Customer2"
            };

            var randomMovie = new RandomMovies
            {
                Movie = movie,
                Customers = new List<Customer>
                {
                    customer1,
                    customer2
                }
            };

            return View(randomMovie);
        }
        [Route("movies/released/{year:regex(\\d{4}):range(1990,2050)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View(id == 1 ? 
                new Movie() {Name = "Bohemian Raphsody"} : 
                new Movie() {Name = "Captain Marvel"});
        }
    }
}