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

        public async Task<List<Movie>> GetMovies() => 
            await _context
                .Movie
                .OrderBy(m=>m.Title)
                .ToListAsync();
        

        public async Task<Movie> GetMovieById(int id) => 
            await _context
                .Movie
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

        public bool MovieExists(int id) => _context.Movie.Any(e => e.Id == id);

        public async Task<List<Movie>> GetMoviesByGenre(string genre) {
            return await _context
                .Movie
                .Where(m=>m.Genre.ToLower().StartsWith(genre.ToLower()))
                .OrderBy(m=>m.Title)
                .ToListAsync();
        }

        public async Task<List<Movie>> GetMoviesByRating(int rating) => 
            await _context
                .Movie
                .Where(m => m.Rating>=rating)
                .OrderByDescending(m=>m.Rating)
                .ThenBy(m=>m.Title)
                .ToListAsync();

        public async Task<List<Movie>> GetMoviesByYear(int year) => 
            await _context
                .Movie
                .Where(m => m.Year == year)
                .OrderBy(m=>m.Title)
                .ToListAsync();
        
    }
}
