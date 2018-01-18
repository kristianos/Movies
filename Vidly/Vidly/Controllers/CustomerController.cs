using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private List<Customer> customers;
        public CustomerController()
        {
            customers = new List<Customer>()
            {
                new Customer() {Name = "Albert"}
            };
        }
        public ActionResult Index()
        {

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id);

            return View(customer);
        }
        
    }
}
