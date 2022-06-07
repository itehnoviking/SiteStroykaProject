using stroyka.DataAccess;
using stroyka.Models;

namespace stroyka.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Feedback> Feedbacks { get; }

        Task<int> Commit();
    }
}
