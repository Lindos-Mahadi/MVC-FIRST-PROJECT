using MVC_FIRST_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_FIRST_PROJECT.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "lindos" };
            return View(movie);
        }
    }
}