using System;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;
//using System.Data.Entity;
using System.Linq;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost] // Input of our application
        public IHttpActionResult CreateNewRentals(NewRentalDto newRentalDto)
        {
            // No MovieIds
            if (newRentalDto.MovieIds.Count == 0)
                return BadRequest("No MovieIds have been given.");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRentalDto.CustomerId);
            // CustomerId is invalid
            if (customer == null)
                return BadRequest("CustomerId is not valid.");
            // One or more MovieIds are invalid
            var movies = _context.Movies.Where(
                m => newRentalDto.MovieIds.Contains(m.Id)).ToList();
            // One or more movieIds are invalid
            if (movies.Count != newRentalDto.MovieIds.Count)
                return BadRequest("One or more MovieIds are invalid");


            foreach (var movie in movies)
            {
                // One or more movies are not available
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
