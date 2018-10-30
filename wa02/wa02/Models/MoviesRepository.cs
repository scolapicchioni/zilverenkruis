using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wa02.Models {
    public class MoviesRepository : IMoviesRepository {
        private readonly ApplicationContext _context;

        public MoviesRepository(ApplicationContext context) {
            _context = context;
        }

        public async Task<List<Movie>> GetMovies() {
            return await _context.Movie.ToListAsync();
        }

        public async Task<Movie> GetMovieById(int id) => await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);

        public async Task Insert(Movie movie) {
            _context.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Movie movie) {
            try {
                _context.Update(movie);
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!MovieExists(movie.Id)) {
                    throw new NotFoundException();
                } else {
                    throw new UpdateConcurrencyException();
                }
            }
        }

        public async Task Delete(int id) {
            var movie = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
        }

        public bool MovieExists(int id) {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
