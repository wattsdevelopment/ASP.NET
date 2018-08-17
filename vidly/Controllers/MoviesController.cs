using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vidly.Models;
namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: moviews/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "shrek" };
            return View (movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return View (year + "/" + month);
        }
    }
}
