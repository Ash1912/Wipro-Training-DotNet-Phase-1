using CodingAssignment2.Context;
using CodingAssignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodingAssignment2.Controllers
{
    [ApiController]
    [Route("api/directors")]
    public class DirectorsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DirectorsController(AppDbContext context)
        {
            _context = context;
        }

        // Get all directors with their movies
        [HttpGet]
        public async Task<IActionResult> GetDirectors()
        {
            var directors = await _context.Directors
                                          .Include(d => d.Movies)
                                          .Select(d => new
                                          {
                                              d.Id,
                                              d.Name,
                                              Movies = d.Movies.Select(m => new
                                              {
                                                  m.Id,
                                                  m.Title,
                                                  m.ReleaseYear
                                              }).ToList()
                                          })
                                          .ToListAsync();
            return Ok(directors);
        }

        // Get a single director by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDirector(int id)
        {
            var director = await _context.Directors
                                         .Include(d => d.Movies)
                                         .Where(d => d.Id == id)
                                         .Select(d => new
                                         {
                                             d.Id,
                                             d.Name,
                                             Movies = d.Movies.Select(m => new
                                             {
                                                 m.Id,
                                                 m.Title,
                                                 m.ReleaseYear
                                             }).ToList()
                                         })
                                         .FirstOrDefaultAsync();

            if (director == null)
                return NotFound(new { message = "Director not found." });

            return Ok(director);
        }

        // Create a new director
        [HttpPost]
        public async Task<IActionResult> CreateDirector([FromBody] Director director)
        {
            if (string.IsNullOrWhiteSpace(director.Name))
                return BadRequest(new { message = "Director name is required." });

            _context.Directors.Add(director);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDirector), new { id = director.Id }, director);
        }

        // Delete a director
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDirector(int id)
        {
            var director = await _context.Directors.Include(d => d.Movies).FirstOrDefaultAsync(d => d.Id == id);
            if (director == null)
                return NotFound(new { message = "Director not found." });

            // Prevent deletion if the director has associated movies
            if (director.Movies.Any())
                return BadRequest(new { message = "Cannot delete director with associated movies." });

            _context.Directors.Remove(director);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // Get all movies by a specific director
        [HttpGet("{directorId}/movies")]
        public async Task<IActionResult> GetMoviesByDirector(int directorId)
        {
            var movies = await _context.Movies
                                       .Where(m => m.DirectorId == directorId)
                                       .Select(m => new
                                       {
                                           m.Id,
                                           m.Title,
                                           m.ReleaseYear
                                       })
                                       .ToListAsync();

            if (!movies.Any())
                return NotFound(new { message = "No movies found for this director." });

            return Ok(movies);
        }
    }
}
