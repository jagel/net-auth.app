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
    internal class ModelCatalogItemBuild : BuildBaseEntityAudit<CatalogItem>, IEntityModelBuilder
    {
        public ModelBuilder BuildEntity(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CatalogItem>(entity =>
            {

                entity.Property(x => x.Name)
                    .HasMaxLength(DatabaseStandards.NAME_LENGHT)
                    .IsRequired(true);

                entity.Property(x => x.ItemKey)
                    .HasMaxLength(DatabaseStandards.KEYSHORT_NAME)
                    .IsRequired(true);

                entity.Property(x => x.Order)
                    .IsRequired(false);

                entity.HasOne(x => x.Catalog)
                    .WithMany(x => x.CatalogItems)
                    .HasForeignKey(x => x.CatalogId);
            });

            return modelBuilder;
        }
    }
}
