using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wa02.Models {
    public class CommentsRepository : ICommentsRepository {
        private readonly ApplicationContext _context;

        public CommentsRepository(ApplicationContext context) {
            _context = context;
        }

        public async Task<List<Comment>> GetComments() =>
            await _context
                .Comment
                .OrderBy(m => m.Title)
                .ToListAsync();


        public async Task<Comment> GetCommentById(int id) =>
            await _context
                .Comment
                .FirstOrDefaultAsync(m => m.Id == id);

        public async Task Insert(Comment comment) {
            _context.Add(comment);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Comment comment) {
            try {
                _context.Update(comment);
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!CommentExists(comment.Id)) {
                    throw new NotFoundException();
                } else {
                    throw new UpdateConcurrencyException();
                }
            }
        }

        public async Task Delete(int id) {
            var comment = await _context.Comment.FindAsync(id);
            _context.Comment.Remove(comment);
            await _context.SaveChangesAsync();
        }

        public bool CommentExists(int id) => _context.Comment.Any(e => e.Id == id);
        
        public async Task<List<Comment>> GetCommentsByMovieId(int movieId) =>
            await _context
                .Comment
                .Where(c => c.MovieId == movieId)
                .ToListAsync();
    }
}

