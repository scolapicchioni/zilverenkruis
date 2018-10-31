using System.Collections.Generic;
using System.Threading.Tasks;

namespace wa02.Models {
    public interface ICommentsRepository {
        bool CommentExists(int id);
        Task Delete(int id);
        Task<Comment> GetCommentById(int id);
        Task<List<Comment>> GetCommentsByMovieId(int movieId);
        Task<List<Comment>> GetComments();
        Task Insert(Comment comment);
        Task Update(Comment comment);
    }
}