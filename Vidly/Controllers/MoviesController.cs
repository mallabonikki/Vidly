using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            //instance of movie model
            var movie = new Movie() { Name = "Shrek!" };

            //pass the instance of the movie to return to the view
            return View(movie);
        }


    }
}