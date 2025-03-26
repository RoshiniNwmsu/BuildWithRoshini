using Microsoft.AspNetCore.Mvc;

namespace RoshiniPortfolio.Controllers
{
    public class FeedbackController : Controller
    {
        // Show the feedback form
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Handle feedback form submission
        [HttpPost]
        public IActionResult Index(int Rating, string Note)
        {
            // You can later store Rating and Note in a database
            Console.WriteLine($"Rating: {Rating}, Note: {Note}");

            // Temporary success message
            ViewBag.Message = "Thanks for your feedback!";
            return View();
        }
    }
}