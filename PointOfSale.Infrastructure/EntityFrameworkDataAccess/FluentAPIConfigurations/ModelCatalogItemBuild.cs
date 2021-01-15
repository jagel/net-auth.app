using Common.Domain.Definitions;
using Common.Infrastructure.EntityFrameworkTools.EntityBases;
using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;

namespace PointOfSale.Infrastructure.FluentAPIConfigurations
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
