using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wa02.Controllers;
using wa02.Models;
using Xunit;

namespace wa02.Tests {
    public class MoviesControllerTests {
        [Fact]
        public async Task Index_ReturnsAViewResult_WithAListOf2Movies() {
            // Arrange (given)
            var mockRepo = new Mock<IMoviesRepository>();
            mockRepo.Setup(repo => repo.GetMovies())
                .ReturnsAsync(()=>new List<Movie>() { new Movie() , new Movie() });
            var controller = new MoviesController(mockRepo.Object);

            // Act (when)
            var result = await controller.Index();
            
            // Assert (then)
            ViewResult viewResult = Assert.IsType<ViewResult>(result);
            IEnumerable<Movie> model = Assert.IsAssignableFrom<IEnumerable<Movie>>(
                viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }
    }
}
