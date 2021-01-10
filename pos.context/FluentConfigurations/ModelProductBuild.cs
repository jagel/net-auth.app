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
