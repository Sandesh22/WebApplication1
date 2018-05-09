using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Rondom()
        {

            var moview = new Movie() { Id=1,Name="shrek!"};
            var customer = new List<Customer>
            {
                new Customer {Name="Cutomer1",Id=1 },
                 new Customer {Name="Cutomer2",Id=2 }
            };
            RandomodelViewModel randomodelViewModel = new RandomodelViewModel {
                Movie = moview,
                Customes = customer
            };
            return View(randomodelViewModel);
            //return RedirectToAction("index","home",new { name="sandesh"});
        }
        public ActionResult Edit(int id )
        {
            return Content("Id = "+id);
        }
        public ActionResult Index(int ?pageIndex , string sortBy)
        {

            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Title";
            }
            return Content(pageIndex + "And " + sortBy);
        }

        [Route("Movies/Released/{year:regex(\\d{4}):range(1900,2020)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int? year, int? month)
        {
            return Content("Year "+year +" / "+ month);
        }
    }
}