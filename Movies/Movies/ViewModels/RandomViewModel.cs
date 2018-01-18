using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.Models;

namespace Movies.ViewModels
{
    public class RandomViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}
