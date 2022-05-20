using Microsoft.EntityFrameworkCore;
using stroyka.Entities;

namespace stroyka
{
    public class StroykaContext : DbContext
    {
        public DbSet<ClientFeedback> ClientFeedbacks { get; set; }
        public StroykaContext(DbContextOptions<StroykaContext> options) : base(options)
        {
        }
    }
}
