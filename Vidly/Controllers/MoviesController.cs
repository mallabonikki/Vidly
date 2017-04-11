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
    //[RouteArea("movies")]
    [RoutePrefix("movies")]
    [Route("{action=index}")] //Could only work on query string url's if the action method parameter is appended
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            //Create a movie
            var movie = new Movie()
            {
                Name = "Shrek"
            };

            //Create List of Customers
            var customers = new List<Customer>
            {
                new Customer { Name = "Melarie Cortina" },
                new Customer { Name = "Nicanor Mallabo" }
            };

            //create a ViewModel
            var viewModel = new RandomViewMovieModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);


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