using Microsoft.EntityFrameworkCore;

namespace CoreExample.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=YUNUSEMRE\SQLEXPRESS;Database=Shop;User Id=sa;Password=83930621;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
