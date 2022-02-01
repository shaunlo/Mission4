using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MoviesContext MovContext { get; set; }
        public HomeController(ILogger<HomeController> logger, MoviesContext MovName)
        {
            _logger = logger;
            MovContext = MovName;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NullResult()
        {
            return View();
        }
        public IActionResult MyPodcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddMovies()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMovies(AddMovies am)
        {
            if (ModelState.IsValid) 
            {
                MovContext.Add(am);
                MovContext.SaveChanges();

                return View("Confirmation", am);
            }

            return RedirectToAction("NullResult");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
