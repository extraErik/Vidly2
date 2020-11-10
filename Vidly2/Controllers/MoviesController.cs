using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Despicable Me" },
                new Movie { Id = 2, Name = "Ice Age" },
                new Movie { Id = 3, Name = "Zootopia" }
            };

            return View(movies);
        }
    }
}