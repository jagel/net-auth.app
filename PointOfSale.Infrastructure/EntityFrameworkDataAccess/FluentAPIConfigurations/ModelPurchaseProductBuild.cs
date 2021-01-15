using Common.Domain.Definitions;
using Common.Infrastructure.EntityFrameworkTools.EntityBases;
using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;

namespace PointOfSale.Infrastructure.FluentAPIConfigurations
{
    internal class ModelPurchaseProductBuild : BuildBaseEntitySingle<PurchaseProduct>, IEntityModelBuilder
    {
        public ModelBuilder BuildEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseProduct>(entity =>
            {
                entity.Property(x => x.Amount)
                    .IsRequired(true);

                entity.Property(x => x.UnitPrice)
                    .HasColumnType(DatabaseStandards.SQL_DECIMALTWOPLACES)
                    .IsRequired(true);

                entity.HasOne(x => x.Product)
                   .WithMany(x => x.PurchaseProducts)
                   .HasForeignKey(x => x.ProductId);

                entity.HasOne(x => x.PurchaseSummary)
                   .WithMany(x => x.PurchaseProducts)
                   .HasForeignKey(x => x.PurchaseSummaryId);

            });

            return modelBuilder;
        }
    }
}
