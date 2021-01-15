using context.AutoModelBuilder;
using context.Interfaces;
using domain.Entities;
using Microsoft.EntityFrameworkCore;
using pos.Core.Domain.Entities;
using System;

namespace pos.context.FluentConfigurations
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
