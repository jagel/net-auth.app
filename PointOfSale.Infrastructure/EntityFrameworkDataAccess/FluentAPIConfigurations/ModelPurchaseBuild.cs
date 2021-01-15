using Common.Domain.Definitions;
using Common.Infrastructure.EntityFrameworkTools.EntityBases;
using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;

namespace PointOfSale.Infrastructure.FluentAPIConfigurations
{
    internal class ModelPurchaseBuild : BuildBaseEntitySingle<Purchase>, IEntityModelBuilder
    {
        public ModelBuilder BuildEntity(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.Property(x => x.Discount)
                    .HasColumnType(DatabaseStandards.SQL_DECIMALTWOPLACES)
                    .HasDefaultValue(0)
                    .IsRequired(true);

                entity.Property(x => x.Total)
                   .HasColumnType(DatabaseStandards.SQL_DECIMALTWOPLACES)
                   .IsRequired(true);

                entity.Property(x => x.PurchaseDate)
                   .HasColumnType(DatabaseStandards.SQL_DATETIME)
                   .IsRequired(true);

                entity.HasOne(x => x.User)
                   .WithMany(x => x.Purchases)
                   .HasForeignKey(x => x.UserId);

            });

            return modelBuilder;
        }
    }
}
