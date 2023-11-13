using Microsoft.EntityFrameworkCore;
using TechSolutions01.Models;

namespace TechSolutions01.API.Context
{
    public class TechSolutions01DbContext : DbContext
    {
        public TechSolutions01DbContext(DbContextOptions<TechSolutions01DbContext> options)
            :base(options)
        {            
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
