using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using Vidly.Dtos;
using AutoMapper;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        // Declare an ApplicationDbContext
        private ApplicationDbContext _context;

        // Constructor, Initialize the _context ApplicationDbContext variable
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // Get Api/Movies
        public IHttpActionResult GetMovies()
        {
            // Fetch all movies from the database
            var moviesInDb = _context.Movies.ToList();

            // Initialize moviesDtos by using Mapper.Map() Domain to Dto
            var moviesDto = moviesInDb.Select(Mapper.Map<Movie, MovieDto>);

            //return the content of moviesDto
            return Ok(moviesDto);
        }

        // Get Api/Movies/id - Get request for specific movie
        public IHttpActionResult GetMovie(int id)
        {
            // Fetch this movie from the database
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            // Check if this movie exist
            if (movieInDb == null)
                return NotFound();

            // Initialize movieDto by using Mapper.Map() Domain to Dto
            var movieDto = Mapper.Map<Movie, MovieDto>(movieInDb);

            //return the content of movieDto
            return Ok(movieDto);
        }

        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            // Check the validations for the inputs(Json)
            if (!ModelState.IsValid)
                return BadRequest();

            // Initialize movie by using Mapper.Map() Dto to Domain
            var movie = Mapper.Map<MovieDto, Movie>(movieDto);

            // Add the movie in the memory
            _context.Movies.Add(movie);

            // Save the changes from the memory to the databae
            _context.SaveChanges();

            // Initialize movieDto.id to movie.id to use in the new uri
            movieDto.Id = movie.Id;

            //Return the new Uri path and the content of the newly created movieDto
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
        {
            // Check the validation for correct inputs
            if (!ModelState.IsValid)
                return BadRequest();

            // Fetch this movie from the database
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            // Check if this movie exist
            if (movieInDb == null)
                return NotFound();

            // Map the movieDto values to movieInDb values 
            // Dto values to DB values not the Domain values as it just update the DB 
            Mapper.Map(movieDto, movieInDb);

            // save the changes to the database
            _context.SaveChanges();

            //No need to return any content or Uri path as id and uri path are the same
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            // Fetch this movie in the database
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            //Check this movie if exist
            if (movieInDb == null)
                return NotFound();

            // Remove this movie in the memory
            _context.Movies.Remove(movieInDb);

            //Save the changes from memory to the database;
            _context.SaveChanges();

            //No need to return any content or uri path and no need to use Dto as it is just delete the data
            return Ok();
        }
    }
}
