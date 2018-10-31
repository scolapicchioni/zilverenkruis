using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wa02.Models;

namespace wa02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentsRepository repo;

        public CommentsController(ICommentsRepository repo) {
            this.repo = repo;
        }
        //GET api/Movie/3/Comment
        [HttpGet("/api/Movie/{movieId}/Comments")]
        public async Task<List<Comment>> GetCommentsByMovieId(int movieId) {
            List<Comment> db = await repo.GetCommentsByMovieId(movieId);
            return db.Where(a => a.MovieId == movieId).ToList();
        }

        //GET api/Comment/5
        [HttpGet("{id}", Name = "GetComment")]
        public async Task<ActionResult<Comment>> GetCommentById(int id) {
            Comment comment = await repo.GetCommentById(id);

            if (comment == null) {
                return NotFound();
            }

            return comment;
        }

        //POST api/Comment
        [HttpPost]
        public async Task<IActionResult> Create(Comment comment) {
            //BadRequest if ModelState.Valid is false

            //add the item in the db
            await repo.Insert(comment);

            return CreatedAtRoute("GetComment", new { id = comment.Id }, comment);
        }

        //PUT api/Comment/2
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Comment comment) {
            //BadRequest if ModelState.Valid is false

            Comment OldComment = await repo.GetCommentById(id);

            if (OldComment == null) {
                return NotFound();
            }

            //modify the item in the db
            await repo.Update(comment);

            return NoContent();
        }

        //DELETE api/Comment/2
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            Comment OldComment = await repo.GetCommentById(id);

            if (OldComment == null) {
                return NotFound();
            }

            //delete the item in the db
            await repo.Delete(id);

            return NoContent();
        }
    }
}