using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Models;

namespace SimpleWebApp.Controllers
{
    [ApiController]
    [Route("/api/actors")]
    public class ActorsController : ControllerBase
    {
        private List<Actor> Actors { get; set; }

        public ActorsController()
        {
            Actors = new List<Actor>()
            {
                new Actor() {Id = 1, FirstName = "FirstName1", LastName = "LastName1", Age = 8},
                new Actor() {Id = 2, FirstName = "FirstName2", LastName = "LastName2", Age = 15},
                new Actor() {Id = 3, FirstName = "FirstName3", LastName = "LastName3", Age = 42},
                new Actor() {Id = 4, FirstName = "FirstName4", LastName = "LastName4", Age = 34},
                new Actor() {Id = 5, FirstName = "FirstName5", LastName = "LastName5", Age = 10},
            };
        }
        
        [HttpGet]
        public ActionResult GetAllActors()
        {
            return Ok(Actors);
        }
    }
}