using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{

    public class MovieController : Controller
    {
        private List<Movie> movies;
        public MovieController()
        {
            movies = new List<Movie>()
            {
                new Movie() {Id = 1 ,Name = "Shrek "}
            };
        }
        
        public ActionResult Index()
        {


            return View(movies);
        }

       
        public ActionResult Details(int id)
        {
            var movie = movies.FirstOrDefault(m => m.Id == id);

            return View(movie);
        }

        

    }
}
