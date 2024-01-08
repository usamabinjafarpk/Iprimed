using Assignment.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment.Models;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

       

        [HttpPost("AddMovies")]
        public IActionResult AddMovies(Movie movie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    movie.MovieId = new Random().Next();
                    movieRepository.AddMovies(movie);
                    return Ok(movie);
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
            
        }
        [HttpGet("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            List<Movie> movies=movieRepository.GetAllMovies();
            try
            {
                return Ok(movies);
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
        }
        [HttpGet("GetMovieByActor/{actor}")]
        public IActionResult GetMoviesByActor(string actor)
        {
            try
            {
                return StatusCode(200, movieRepository.GetMoviesByActor(actor));
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
        }
        [HttpGet("GetMoviesByDirector/{director}")]
        public IActionResult GetMoviesByDirector(string director)
        {
            try
            {
                return StatusCode(200, movieRepository.GetMoviesByDirector(director));
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
        }
        [HttpGet("GetMoviesByName/{name}")]
        public IActionResult GetMoviesByName(string name)
        {
            try
            {
                Movie movie = movieRepository.GetMoviesByName(name);
                if (movie != null)
                {
                    return Ok(movie);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
        }
        [HttpGet("GetMoviesByReleaseYear/{year}")]
        public IActionResult GetMoviesByReleaseYear(int year)
        {
            try
            {
                return StatusCode(200, movieRepository.GetMoviesByReleaseYear(year));
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex);
            }
        }
    }
}
