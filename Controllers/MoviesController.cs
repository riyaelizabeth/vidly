using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "shrek" };
            var customers = new List<Customer>
            {
                new Customer{Name="customer1"},
                new Customer{Name="customer2"}

            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customers
            };
            return View(viewModel);
        }

        [Route("Movies/Released/{{year}}/{{month:regex(/d{2}):range(1,12)}}")]
        public IActionResult Edit(int id)
        {
            return Content("id="+ id);
        }
        public IActionResult Index(int? pageIndex , string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content("{0},{1}"
            +pageIndex ,sortBy);
        }
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + "/"+ month );
        }
    }
}

