using System.Collections.Generic;
using System.Threading.Tasks;

namespace wa02.Models {
    public interface IMoviesRepository {
        Task Delete(int id);
        Task<Movie> GetMovieById(int id);
        Task<List<Movie>> GetMovies();
        Task Insert(Movie movie);
        bool MovieExists(int id);
        Task Update(Movie movie);
    }
}