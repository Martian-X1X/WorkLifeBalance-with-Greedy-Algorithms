using Microsoft.EntityFrameworkCore;
using WorkforceScheduler.Models;

namespace WorkforceScheduler.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Shifts> Shifts { get; set; }
    }
}
