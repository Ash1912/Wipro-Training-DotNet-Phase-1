using Microsoft.EntityFrameworkCore;

namespace MVCNlog.Models
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> Op) : base(Op) { }
    }
}
