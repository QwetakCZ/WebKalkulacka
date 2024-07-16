using Microsoft.EntityFrameworkCore;

namespace WebProject.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Calculation> Calculations { get; set; }
    }
    
}
