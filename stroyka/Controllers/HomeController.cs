using Microsoft.AspNetCore.Mvc;
using stroyka.Models;
using System.Diagnostics;

namespace stroyka.Controllers
{
    public class HomeController : Controller
    {
        private readonly StroykaContext _db;

        public HomeController(StroykaContext db)
        {
            _db = db;
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

        [HttpGet]
        public IActionResult Create()
        {
            var model = new Feedback();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Feedback? model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            await _db.Feedbacks.AddAsync(model);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}