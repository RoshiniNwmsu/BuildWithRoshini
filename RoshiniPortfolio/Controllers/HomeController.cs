using Microsoft.AspNetCore.Mvc;

namespace RoshiniPortfolio.Controllers
{
    public class HomeController : Controller
    {
        // Landing/Home page
        public IActionResult Index()
        {
            return View();
        }

        // About Me / Why Me section
        public IActionResult About()
        {
            return View();
        }

        // Projects section
        public IActionResult Projects()
        {
            return View();
        }

        // Travel Moments or Personal Section
        public IActionResult TravelGallery()
        {
            return View();
        }

        // Contact page (optional)
        public IActionResult Contact()
        {
            return View();
        }
    }
}