using efcore2.Models;
using efcore2.Controllers;
using Microsoft.EntityFrameworkCore;


namespace efcore2.Models {
    public class ProductDbContext : DbContext {
        public ProductDbContext() { }
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TIXNTHXNH;Initial Catalog=DBName;Integrated Security=True");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}