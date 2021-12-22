using Microsoft.EntityFrameworkCore;
using PizzaTask.Models;

namespace PizzaTask.DataLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Pizza> Pizzas { get; set; }
    }
}
