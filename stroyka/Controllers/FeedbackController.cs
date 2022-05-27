using Microsoft.AspNetCore.Mvc;
using stroyka.Models;

namespace stroyka.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly StroykaContext _db;

        public FeedbackController(StroykaContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(new FeedbacksListViewModel
            {
                Feedbacks = _db.Feedbacks
                .OrderByDescending(x => x.Id)
            });
        }
    }
}
