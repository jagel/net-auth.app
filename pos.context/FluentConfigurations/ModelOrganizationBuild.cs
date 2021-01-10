using context.AutoModelBuilder;
using context.Interfaces;
using Microsoft.EntityFrameworkCore;
using pos.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace pos.context.FluentConfigurations
{
    internal class ModelOrganizationBuild : BuildBaseEntityDescriptive<Organization>, IEntityModelBuilder
    {
        public ModelBuilder BuildEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>(entity => {
                
                entity.Property(x => x.IsPrimary)
                    .IsRequired(true);

                entity.HasOne(x => x.OrganizationParent)
                    .WithMany(x => x.OrganizationChilds)
                    .HasForeignKey(x => x.OrganizationParentId)
                    .IsRequired(false);
                    
            });
            return modelBuilder;
        }
    }
}
