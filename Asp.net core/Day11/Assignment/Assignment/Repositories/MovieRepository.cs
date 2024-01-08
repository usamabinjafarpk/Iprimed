using Assignment.Models;

namespace Assignment.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> movies= new List<Movie>()
        {
            new Movie(){MovieId=new Random().Next(),Actor="Dq",Director="Prashaanth neel",Lang="Malayalam",MovieName="Blah",ReleaseYear=2022}
        };
       
        public void AddMovies(Movie movie)
        {
            movies.Add(movie);
        }

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public List<Movie> GetMoviesByActor(string actor)
        {
            List<Movie> result = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.Actor == actor)
                {
                    result.Add(movie); 
                }
            }
            return result;
        }

        public List<Movie> GetMoviesByDirector(string director)
        {
            List<Movie> result = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.Director == director)
                {
                    result.Add(movie);
                }
            }
            return result;
        }

        public Movie GetMoviesByName(string name)
        {
            foreach (var movie in movies)
            {
                if(movie.MovieName == name)
                {
                    return movie;
                }
            }
            return null;
        }

        public List<Movie> GetMoviesByReleaseYear(int year)
        {
            List <Movie> result = new List<Movie>();
            foreach (var movie in movies)
            {
                if(year == movie.ReleaseYear)
                {
                    result.Add(movie);
                }
            }
            return result;
        }
    }
}
