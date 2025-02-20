using Microsoft.EntityFrameworkCore;
using WebApplicationDatabaseApi1.Models;

namespace WebApplicationDatabaseApi1.Context
{
    public class DBContext : DbContext
    {
        public DBContext()
        {

        }
        public DBContext(DbContextOptions<DBContext> contextOptionsBuilder) : base(contextOptionsBuilder)
        { }
        public DbSet<Student> Students { get; set; }
    }

}
