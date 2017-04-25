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

        public ActionResult Details(int Id)
        {
            var movie = _dbContext.Movies.Include(m => m.GenreType).SingleOrDefault(m => m.Id == Id);

            return View(movie);
        }
    }
}