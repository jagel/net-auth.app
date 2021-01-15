using Common.Domain.Definitions;
using Common.Infrastructure.EntityFrameworkTools.EntityBases;
using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Common.Infrastructure.EntityFrameworkTools.Tools;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;

namespace PointOfSale.Infrastructure.FluentAPIConfigurations
{
    internal class ModelOrganizationUserBuild : BuildBaseEntitySingle<OrganizationUser>, IEntityModelBuilder
    {
        public ModelBuilder BuildEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizationUser>(entitiy => {
                
                entitiy.Property(x => x.UserStatus)
                    .HasDefaultValue(EDB_UserStatus.Offline)
                    .HasMaxLength(DatabaseStandards.ENUM_NAME)
                    .HasConversion(Converters.FromEnum<EDB_UserStatus>())
                    .IsRequired(true);

                entitiy.HasOne(x => x.Organization)
                   .WithMany(x => x.OrganizationUsers)
                   .HasForeignKey(x => x.OrganizationId);

                entitiy.HasOne(x => x.User)
                    .WithMany(x => x.OrganizationUsers)
                    .HasForeignKey(x => x.UserId);
            });

            return modelBuilder;
        }
    }
}
