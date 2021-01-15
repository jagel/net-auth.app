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
    internal class ModelUserBuild : BuildBaseEntityAudit<User>, IEntityModelBuilder
    {
        public ModelBuilder BuildEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(x => x.Email)
                   .IsRequired(true)
                   .IsUnicode()
                   .HasMaxLength(DatabaseStandards.NAME_LENGHT);

                entity.Property(x => x.UserName)
                    .IsRequired(true)
                    .IsUnicode()
                    .HasMaxLength(DatabaseStandards.NAME_LENGHT);

                entity.Property(x => x.Pasword)
                    .IsRequired(true)
                    .HasMaxLength(DatabaseStandards.CYPHER_GUID);

                entity.Property(x => x.Token)
                    .IsRequired(false)
                    .HasMaxLength(DatabaseStandards.CYPHER_GUID);

                entity.Property(x => x.ExpirationDate)
                  .IsRequired(true)
                  .HasColumnType(DatabaseStandards.SQL_DATETIME)
                  .HasComment("Session expiration date");
            });

            return modelBuilder;
        }
    }
}
