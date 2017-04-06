using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    //[RouteArea("movies")]
    [RoutePrefix("movies")]
    [Route("{action=index}")] //Could only work on query string url's if the action method parameter is appended
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
            return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" });
        }

        // movies/edit/1 or movies/edit?id=1
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

        //This will be movies/Release/1978/06 or movies/Release?year=1978&month=06
        //It could be embeded url or query string url
        [Route("~/movies/released/{year:range(2016,2017)?}/{month:regex(\\d{2})?}")]
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }
    }
}