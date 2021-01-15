using Common.Domain.Definitions;
using Common.Infrastructure.EntityFrameworkTools.EntityBases;
using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;

namespace PointOfSale.Infrastructure.FluentAPIConfigurations
{
    internal class ModelProductPriceBuild : BuildBaseEntityAudit<ProductPrice>, IEntityModelBuilder
    {
        public ModelBuilder BuildEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductPrice>(entity =>
            {
                entity.Property(x => x.UnitPrice)
                    .HasColumnType(DatabaseStandards.SQL_DECIMALTWOPLACES)
                    .IsRequired(true);

                entity.Property(x => x.IsCurrentPrice)
                     .IsRequired(true);

                entity.HasOne(x => x.Organization)
                    .WithMany(x => x.ProductPrices)
                    .HasForeignKey(x => x.OrganizationId);

                entity.HasOne(x => x.Product)
                    .WithMany(x => x.ProductPrices)
                    .HasForeignKey(x => x.ProductId);

            });

            return modelBuilder;
        }
    }
}
