

namespace stroyka.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly StroykaContext _context;
        private readonly Guid guid = new Guid("00000000000000000000000000000000");

        public FeedbackRepository(StroykaContext context)
        {
            _context = context;
        }

        public IQueryable<Feedback> Feedbacks => _context.Feedbacks;
        public void SaveFeedback(Feedback f)
        {
            if(f.Id == guid)
            {
                _context.Feedbacks.Add(f);
            }

            _context.SaveChanges();
        }
    }
}