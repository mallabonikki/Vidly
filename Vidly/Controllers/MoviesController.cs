using System;
using System.Collections;
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
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Title = "Shrek" },
                new Movie { Id = 2, Title = "Wall-e" }
            };
        }

        public ActionResult Details(int Id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.Id == Id);

            return View(movie);
        }
    }
}