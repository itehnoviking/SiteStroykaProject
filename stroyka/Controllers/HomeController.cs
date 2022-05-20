using Microsoft.AspNetCore.Mvc;
using stroyka.Models;
using System.Diagnostics;

namespace stroyka.Controllers
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

        public IActionResult RemontnieRaboti()
        {
            return View();
        }

        public IActionResult StroitelnieRaboti() 
        { 
            return View(); 
        }

        public IActionResult Proektirovanie()
        {
            return View();
        }

        public IActionResult Design()
        {
            return View();
        }

        public IActionResult PriceAndServices()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
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