using Microsoft.EntityFrameworkCore;

namespace ModelViewController.Models
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; } 

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }
    }
}
