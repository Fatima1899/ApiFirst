using Microsoft.EntityFrameworkCore;

namespace ApiFirst.Data.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base (options)
        {

        }

        DbSet<Product> Products { set; get; }
    }
}
