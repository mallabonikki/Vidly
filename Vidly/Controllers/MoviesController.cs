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
            //return View(movie);

            //Examples of different action results
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        // /movies/index or /movies or test a query string with parameters
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("page Index={0}&sort By={1}", pageIndex, sortBy));
        }

    }
}