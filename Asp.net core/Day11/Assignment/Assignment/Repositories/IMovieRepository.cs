using Assignment.Models;

namespace Assignment.Repositories
{
    public interface IMovieRepository
    {
        void AddMovies(Movie movie);
        List<Movie> GetAllMovies();
        Movie GetMoviesByName(string name);
        List<Movie> GetMoviesByActor(string actor);
        List<Movie> GetMoviesByReleaseYear(int year);
        List<Movie> GetMoviesByDirector(string director);

     

    }
}
