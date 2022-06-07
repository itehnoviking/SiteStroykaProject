using stroyka.Models;

namespace stroyka.DataAccess
{
    public class FeedbackRepository : Repository<Feedback>
    {
        public FeedbackRepository(StroykaContext context) : base(context)
        {
        }
    }
}
