using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;

namespace PointOfSale.Infrastructure.EntityFrameworkDataAccess.ContextConfiguration
{
    public class PointOfSaleDbContext : DbContext
    {
        public PointOfSaleDbContext(DbContextOptions<PointOfSaleDbContext> options) 
            : base(options)
        {
        }

        // ----------------------------- C -----------------------------------
        public DbSet<CatalogItem> CatalogItem { get; set; }
        public DbSet<Catalog> Catalog { get; set; }

        // ----------------------------- O -----------------------------------
        public DbSet<Organization> Organization { get; set; }
        public DbSet<OrganizationUser> OrganizationUser { get; set; }

        // ----------------------------- P -----------------------------------
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductPrice> ProductPrice { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PurchaseProduct> PurchaseProduct { get; set; }

        // ----------------------------- S -----------------------------------
        public DbSet<Stock> Stock { get; set; }

        // ----------------------------- U -----------------------------------
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SetDynamicModelBuilder();
        }
    }
}
