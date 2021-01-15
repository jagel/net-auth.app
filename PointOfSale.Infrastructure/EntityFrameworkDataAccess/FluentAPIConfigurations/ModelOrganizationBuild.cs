using Common.Infrastructure.EntityFrameworkTools.EntityBases;
using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;

namespace PointOfSale.Infrastructure.FluentAPIConfigurations
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
