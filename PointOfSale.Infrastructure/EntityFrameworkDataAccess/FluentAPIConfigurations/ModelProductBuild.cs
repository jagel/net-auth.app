using Common.Domain.Definitions;
using Common.Infrastructure.EntityFrameworkTools.EntityBases;
using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;

namespace PointOfSale.Infrastructure.FluentAPIConfigurations
{
    internal class ModelProductBuild : BuildBaseEntityDescriptive<Product>, IEntityModelBuilder
    {
        public ModelBuilder BuildEntity(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Product>(entity => {

                entity.Property(x => x.Barcode)
                    .HasMaxLength(DatabaseStandards.BARCODE_LENGHT)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity.Property(x => x.Reference)
                    .HasMaxLength(DatabaseStandards.DESCRIPTION_LENGHT)
                    .IsRequired(false);

                entity.HasOne(x => x.Brand)
                    .WithMany(x => x.Products)
                    .HasForeignKey(x => x.BrandId);

            });

            return modelBuilder;
        }
    }
}
