using CodingAssignment2.Context;
using CodingAssignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodingAssignment2.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        // Get all movies with director details
        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _context.Movies
                                       .Include(m => m.Director)
                                       .Select(m => new
                                       {
                                           m.Id,
                                           m.Title,
                                           m.ReleaseYear,
                                           m.DirectorId,
                                           Director = new
                                           {
                                               m.Director.Id,
                                               m.Director.Name
                                           }
                                       })
                                       .ToListAsync();
            return Ok(movies);
        }

        // Get a single movie by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            var movie = await _context.Movies
                                      .Include(m => m.Director)
                                      .Where(m => m.Id == id)
                                      .Select(m => new
                                      {
                                          m.Id,
                                          m.Title,
                                          m.ReleaseYear,
                                          m.DirectorId,
                                          Director = new
                                          {
                                              m.Director.Id,
                                              m.Director.Name
                                          }
                                      })
                                      .FirstOrDefaultAsync();

            if (movie == null)
                return NotFound(new { message = "Movie not found." });

            return Ok(movie);
        }

        // Create a new movie
        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] Movie movie)
        {
            // Validate the input
            if (string.IsNullOrWhiteSpace(movie.Title))
                return BadRequest(new { message = "Title is required." });

            if (movie.ReleaseYear <= 0)
                return BadRequest(new { message = "Release year must be a valid positive number." });

            // Check if the Director exists
            var directorExists = await _context.Directors.AnyAsync(d => d.Id == movie.DirectorId);
            if (!directorExists)
                return BadRequest(new { message = "Invalid DirectorId. Director not found." });

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, new
            {
                movie.Id,
                movie.Title,
                movie.ReleaseYear,
                movie.DirectorId
            });
        }


        // Update an existing movie
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, [FromBody] Movie updatedMovie)
        {
            if (id != updatedMovie.Id)
                return BadRequest(new { message = "Movie ID mismatch." });

            var existingMovie = await _context.Movies.FindAsync(id);
            if (existingMovie == null)
                return NotFound(new { message = "Movie not found." });

            // Validate if DirectorId is valid
            var directorExists = await _context.Directors.AnyAsync(d => d.Id == updatedMovie.DirectorId);
            if (!directorExists)
                return BadRequest(new { message = "Invalid DirectorId. Director not found." });

            existingMovie.Title = updatedMovie.Title;
            existingMovie.ReleaseYear = updatedMovie.ReleaseYear;
            existingMovie.DirectorId = updatedMovie.DirectorId;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // Delete a movie
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
                return NotFound(new { message = "Movie not found." });

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
