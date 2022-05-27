using Microsoft.EntityFrameworkCore;
using stroyka.Entities;

namespace stroyka.Models
{

    public class StroykaContext : DbContext
    {
        public StroykaContext(DbContextOptions<StroykaContext> options) : base(options)
        {
        }
        public DbSet<Feedback> Feedbacks { get; set; }

    }
}
