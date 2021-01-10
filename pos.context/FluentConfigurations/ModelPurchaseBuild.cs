using context.AutoModelBuilder;
using context.Interfaces;
using domain.Entities;
using Microsoft.EntityFrameworkCore;
using pos.Core.Domain.Entities;
using System;

namespace pos.context.FluentConfigurations
{
    internal class ModelPurchaseBuild : BuildBaseEntitySingle<Purchase>, IEntityModelBuilder
    {
        public ModelBuilder BuildEntity(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.Property(x => x.Discount)
                    .HasDefaultValue(0)
                    .IsRequired(true);

                entity.Property(x => x.Total)
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
