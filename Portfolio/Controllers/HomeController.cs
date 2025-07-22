using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult LMSProject()
        {
            return View();
        }

        public IActionResult SentimentProject()
        {
            return View();
        }

        public IActionResult FakeImageProject()
        {
            return View();  
        }

        public IActionResult CodeSavior()
        {
            return View();
        }

        public IActionResult RecommendationSystem()
        {
            return View();
        }
        public IActionResult MachineTranslationEN_AR()
        {
            return View();
        }
        public IActionResult Resume(string type)
        {
            switch (type)
            {
                case "web":
                    return RedirectToAction("WebResume");
                case "ai":
                    return RedirectToAction("AIResume");
            }
            return View();
        }
        public IActionResult WebResume()
        {
            return View();
        }
        public IActionResult AIResume()
        {
            return View();
        }

        public IActionResult HireMe()
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
