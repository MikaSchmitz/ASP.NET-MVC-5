using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        IEnumerable<Movie> movies = new List<Movie>
        {
            new Movie{ Id = 1, Name = "The Incredibles" },
            new Movie{ Id = 2, Name = "Shrek" }
        };

        // GET: Movies
        public ActionResult Index()
        {
            return View(movies);
        }

        // GET: Movie by id
        public ActionResult Details(int? id)
        {
            var movie = movies.SingleOrDefault(x => x.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}