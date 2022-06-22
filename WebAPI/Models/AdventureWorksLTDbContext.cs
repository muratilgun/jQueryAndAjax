using Microsoft.EntityFrameworkCore;

namespace WebAPI
{
    public partial class AdventureWorksLTDbContext : DbContext
    {
        public AdventureWorksLTDbContext(
            DbContextOptions<AdventureWorksLTDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductModel> ProductModels { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}