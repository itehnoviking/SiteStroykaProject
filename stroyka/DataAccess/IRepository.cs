using stroyka.Entities;

namespace stroyka.DataAccess
{
    public interface IRepository<T> where T : BaseEntity
    {
        public Task<T> GetById(Guid id);
        public Task Remove(Guid id);
        public void Dispose();
    }
}
