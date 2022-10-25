using Microsoft.EntityFrameworkCore;

namespace my_book_store_app.Data.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Books> Books { get; set; }
    }
}
