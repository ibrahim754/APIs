using Microsoft.EntityFrameworkCore;

namespace MovieApi.Models
{
    public class ApplicationDBContext:DbContext

    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)
        {
        }
        public DbSet<Genre> Genres { get; set; }

    }
}
