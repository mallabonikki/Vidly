using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    
    public class MoviesController : Controller
    {
        private ApplicationDbContext _dbContext;

        public MoviesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }

        public ActionResult Index()
        {
           var movies = _dbContext.Movies.Include(m => m.GenreType).ToList();

            return View(movies);
        }

        public ActionResult New()
        {
            var genreTypes = _dbContext.GenreTypes.ToList(); //Initialize genreTypes variable = list of records from  GenreTypes 

            var viewModel = new MovieFormViewModel() //It's one to many relationship created from IdentityModel
            {
                GenreTypes = genreTypes //Initialize GenreTypes model-properties = GenreTypes list of records
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            //Fetch from the database the specific movie to edit
            var movie = _dbContext.Movies.SingleOrDefault(m => m.Id == id);

            //check the specific movie if exist.
            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel()
            {
                Movie = movie, //Initialize Movie model-property = specific movie from the database   
                GenreTypes = _dbContext.GenreTypes.ToList() //IEnumrable GenreType GenreTypes model properties = list of records from GenreTypes
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
                _dbContext.Movies.Add(movie); //Add new record in the memory
            else
            {
                var movieInDb = _dbContext.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Title = movie.Title;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.AddedDate = movie.AddedDate;
                movieInDb.NumberOfStock = movie.NumberOfStock;
                movieInDb.GenreTypeId = movie.GenreTypeId;
                
            }

            _dbContext.SaveChanges(); //Save changes to the database

            return RedirectToAction("Index", "Movies");
        }
    }
}