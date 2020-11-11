using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.GenreType).ToList();

            return View(movies);
        }

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            var specifiedMovie = _context.Movies.Include(c => c.GenreType).SingleOrDefault(item => item.Id == id);

            if (specifiedMovie != null)
            {
                return View(specifiedMovie);
            }
            else
            {
                return HttpNotFound();
            }

        }
    }
}