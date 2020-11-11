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
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"},
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        // GET: Movies/movies
        public ActionResult Movies()
        {
            
            var listOfMovies = new List<Movie>()
                {
                    new Movie { Name = "Shrek!", Id = 1},
                    new Movie { Name = "Wall-E", Id = 2}
                };



            var moviesViewModel = new MoviesViewModel()
            {
                ListOfMovies = listOfMovies
            };


            return View(moviesViewModel);
        }

        //Get: Movies/Customers
        public ActionResult Customer()
        {
            var listOfCustomers = new List<Customer>()
            {
                new Customer {Name = "João", Id = 1 },
                new Customer {Name = "Paulo", Id = 2 },
                new Customer {Name = "Pacheco", Id = 3 }
            };

            var customerViewModel = new CustomerViewModel()
            {
                ListOfCustomers = listOfCustomers
            };

        return View(customerViewModel);
        }


        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}