using context.AutoModelBuilder;
using context.Interfaces;
using context.Tools;
using domain.Entities;
using Microsoft.EntityFrameworkCore;
using pos.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace pos.context.FluentConfigurations
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
