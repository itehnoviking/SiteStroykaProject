using Microsoft.AspNetCore.Mvc;
using stroyka.Core;
using stroyka.Models;

namespace stroyka.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly StroykaContext _db;
        private readonly IFeedbacksService _feedbacksService;

        public FeedbackController(StroykaContext db, IFeedbacksService feedbacksService)
        {
            _db = db;
            _feedbacksService = feedbacksService;
        }

        public IActionResult Index()
        {
            //var feedbacks = new List<Feedback>();

            return View(new FeedbackListItemViewModel
            {
                Feedbacks = _db.Feedbacks.OrderByDescending(x => x.Id)
            }) ;
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var deleteModel = new DeleteModel()
            {
                Id = id
            };
            return View(deleteModel);
        }

        [HttpPost]
        public IActionResult Delete(DeleteModel model)
        {
            _feedbacksService.DeleteAsync(model.Id);
            return RedirectToAction("Index", "Feedback");
        }
        
    }
}
