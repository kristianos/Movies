using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movies.Models;
using Movies.ViewModels;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek"};
            var customers = new List<Customer>()
            {
                new Customer() { Name = "Albert Anton"},
                new Customer() { Name = "Cristian ANton"}
            };

            var vm = new RandomViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(vm);
        }

    }
}