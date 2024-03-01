
using Microsoft.EntityFrameworkCore;

namespace WebApiDemo.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext() { }
       
        public ApplicationDBContext(DbContextOptions options):base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=WebApiTest;Integrated Security=True");
        }
        public DbSet<Emp> Emps { get; set; }

    }
}
