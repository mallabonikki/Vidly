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

        public ActionResult New()
        {
            //Create the genre-types lists for the drop-down in the MovieForm-view
            var genreTypes = _dbContext.GenreTypes.ToList(); //Initialize genreTypes variable = list of records from  GenreTypes 

            var viewModel = new MovieFormViewModel() //It's one to many relationship created from IdentityModel
            {
                //Movie = new Movie(), //Initialize the default values for the Movie-properties
                GenreTypes = genreTypes //Initialize GenreTypes model-properties = GenreTypes list of records
            };

            //return the view to the MovieForm-view with the object ViewModel.
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    GenreTypes = _dbContext.GenreTypes.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.AddedDate = DateTime.Now;
                _dbContext.Movies.Add(movie); //Add new record in the memory
            }
            else
            {
                var movieInDb = _dbContext.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Title = movie.Title;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberOfStock = movie.NumberOfStock;
                movieInDb.GenreTypeId = movie.GenreTypeId;
            }

            ////A way to see the error on data entity exemption
            //try
            //{
            //    _dbContext.SaveChanges();
            //}
            //catch (System.Data.Entity.Validation.DbEntityValidationException e)
            //{
            //    Console.WriteLine(e);
            //}
            ////---------------

            _dbContext.SaveChanges(); //Save changes to the database

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Index()
        {
           var movies = _dbContext.Movies.Include(m => m.GenreType).ToList();

            return View(movies);
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

        
    }
}