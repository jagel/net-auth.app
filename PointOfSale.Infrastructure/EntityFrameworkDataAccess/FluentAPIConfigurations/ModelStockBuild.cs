using Common.Infrastructure.EntityFrameworkTools.EntityBases;
using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;

namespace PointOfSale.Infrastructure.FluentAPIConfigurations
{
    internal class ModelStockBuild : BuildBaseEntityAudit<Stock>, IEntityModelBuilder
    {
        public ModelBuilder BuildEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>(entity =>
            {
                entity.Property(x => x.Amount)
                    .HasDefaultValue(0)
                    .IsRequired(true);

                entity.HasOne(x => x.Product)
                    .WithMany(x => x.Stocks)
                    .HasForeignKey(x => x.ProductId);

                entity.HasOne(x => x.Organization)
                   .WithMany(x => x.Stocks)
                   .HasForeignKey(x => x.OrganizationId);

            });
            return modelBuilder;
        }
    }
}
