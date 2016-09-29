using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Ramdom
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};

            //ViewData["Movie"] = movie;
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ViewResult Index()
        {
            var movies = GetMovies(); 
             
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {
                new Movie {Id = 1,Name = "Shrek!"},
                new Movie {Id = 2 ,Name = "Wall E"}
            };

            return(movies);
        }

    }
}