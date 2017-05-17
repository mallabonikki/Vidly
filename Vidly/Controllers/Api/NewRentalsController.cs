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
            
            var customer = _context.Customers.Single(c => c.Id == newRentalDto.CustomerId);
            
            var movies = _context.Movies.Where(
                m => newRentalDto.MovieIds.Contains(m.Id)).ToList();

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
