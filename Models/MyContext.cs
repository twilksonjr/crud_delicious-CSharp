using Microsoft.EntityFrameworkCore;

namespace first_entity.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        // dish table is represented by this DbSEt "Dishes"
        public DbSet<Dish> Dishes { get; set; }
    }
}