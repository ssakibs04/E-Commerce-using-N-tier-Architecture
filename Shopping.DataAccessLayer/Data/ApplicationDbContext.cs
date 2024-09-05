using Microsoft.EntityFrameworkCore;
using Shopping.Models;


namespace Shopping.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
            
        }
        public DbSet<Category>categories { get; set; }
    }
}
