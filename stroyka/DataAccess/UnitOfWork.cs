using stroyka.Core;
using stroyka.Models;

namespace stroyka.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StroykaContext _db;
        private readonly IRepository<Feedback> _feedbackRepository;

        public UnitOfWork(StroykaContext db, IRepository<Feedback> feedbackRepository)
        {
            _db = db;
            _feedbackRepository = feedbackRepository;
        }

        public IRepository<Feedback> Feedbacks => _feedbackRepository;

        public async Task<int> Commit()
        {
            return await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
            _feedbackRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
