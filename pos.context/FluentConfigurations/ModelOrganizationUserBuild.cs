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
    internal class ModelOrganizationUserBuild : BuildBaseEntitySingle<OrganizationUser>, IEntityModelBuilder
    {
        public ModelBuilder BuildEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizationUser>(entitiy => {
                
                entitiy.Property(x => x.UserStatus)
                    .HasDefaultValue(EDB_UserStatus.Offline)
                    .HasConversion(Converters.FromEnum<EDB_UserStatus>())
                    .IsRequired(true);

                entitiy.HasOne(x => x.User)
                    .WithMany(x => x.OrganizationUsers)
                    .HasForeignKey(x => x.UserId);

                entitiy.HasOne(x => x.Organization)
                    .WithMany(x => x.OrganizationUsers)
                    .HasForeignKey(x => x.OrganizationId);

            });

            return modelBuilder;
        }
    }
}
