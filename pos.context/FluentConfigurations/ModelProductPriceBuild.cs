using context.AutoModelBuilder;
using context.Interfaces;
using domain.Entities;
using Microsoft.EntityFrameworkCore;
using pos.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace pos.context.FluentConfigurations
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
