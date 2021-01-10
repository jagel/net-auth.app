using context.AutoModelBuilder;
using context.Interfaces;
using Microsoft.EntityFrameworkCore;
using pos.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace pos.context.FluentConfigurations
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
