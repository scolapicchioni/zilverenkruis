using System.Collections.Generic;
using System.Threading.Tasks;

namespace wa02.Models {
    public interface IMoviesRepository {
        Task Delete(int id);
        Task<Movie> GetMovieById(int id);
        Task<List<Movie>> GetMovies();
        Task<List<Movie>> GetMoviesByGenre(string genre);
        Task<List<Movie>> GetMoviesByRating(int rating);
        Task<List<Movie>> GetMoviesByYear(int year);
        Task Insert(Movie movie);
        bool MovieExists(int id);
        Task Update(Movie movie);
    }
}