using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Models;

namespace SimpleWebApp.Controllers
{
    [ApiController]
    [Route("/api/movies")]
    public class MoviesController : ControllerBase
    {
        private List<Movie> Movies { get; set; }

        public MoviesController()
        {
            Movies = new List<Movie>()
            {
                new Movie() {Id = 1, Title = "Title1", Year = 1984},
                new Movie() {Id = 2, Title = "Title2", Year = 2005},
                new Movie() {Id = 3, Title = "Title3", Year = 2000},
                new Movie() {Id = 4, Title = "Title4", Year = 2019},
                new Movie() {Id = 5, Title = "Title5", Year = 2016}
            };
        }
        [HttpGet]
        public ActionResult GetAllMovies()
        {
            return Ok(Movies);
        }
    }
}