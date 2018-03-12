using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilms.Controllers
{
    public class FilmController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Models.clsFilm Film = new Models.clsFilm()
            {
                Headline = "IMAT 2904 Project",
                
                Content = "The Starting bit of the project!!!!!!!! By palwinder And Mohamabddiii"
            };

            return View(Film);

        }
    }
}