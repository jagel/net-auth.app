using Common.Domain.Definitions;
using Common.Infrastructure.EntityFrameworkTools.EntityBases;
using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Common.Infrastructure.EntityFrameworkTools.Tools;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;

namespace PointOfSale.Infrastructure.FluentAPIConfigurations
{
    internal class ModelCatalogBuild : BuildBaseEntityDescriptive<Catalog>, IEntityModelBuilder
    {
        public ModelBuilder BuildEntity(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Catalog>(entity =>
            {
                entity.Property(x => x.OrderDisplay)
                    .HasDefaultValue(EDB_CatalogDisplay.Alphabet_Asc)
                    .HasMaxLength(DatabaseStandards.ENUM_NAME)
                    .HasConversion(Converters.FromEnum<EDB_CatalogDisplay>())
                    .IsRequired(true);
            });

            

            return modelBuilder;
        }
    }
}
