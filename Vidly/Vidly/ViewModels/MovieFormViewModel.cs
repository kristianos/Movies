using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieFormViewModel()
        {
            
        }

        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}