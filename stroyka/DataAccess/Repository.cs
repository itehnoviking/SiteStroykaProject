using Microsoft.EntityFrameworkCore;
using stroyka.Entities;
using stroyka.Models;

namespace stroyka.DataAccess
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly StroykaContext Db;
        private readonly DbSet<T> DbSet;

        public Repository(StroykaContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual async Task<T> GetById(Guid id)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(entity => entity.Id.Equals(id));
        }

        public virtual async Task Remove(Guid id)
        {
            DbSet.Remove(await DbSet.FindAsync(id));
        }
    }
}
