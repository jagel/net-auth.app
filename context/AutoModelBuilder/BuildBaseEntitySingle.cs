using context.Interfaces;
using context.Tools;
using domain.Entities;
using domain.Entities.Bases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace context.AutoModelBuilder
{
    public class BuildBaseEntitySingle<TEntity> : IBaseEntityModelBuilder where TEntity : BaseEntitySingle, new()
    {
        public ModelBuilder BuildBaseEntity(ModelBuilder modelBuilder)
        {
            string EntityName = typeof(TEntity).Name;
            string EntityPKName = $"{EntityName}Id";

            modelBuilder.Entity<TEntity>(entity =>
            {
                entity.Property(x => x.Id)
                    .HasColumnName(EntityPKName);

                entity.HasKey(x => x.Id)
                    .HasName(EntityPKName);

                entity.Property(x => x.Status)
                    .HasDefaultValue(EDB_ItemStatus.Active)
                    .HasConversion(Converters.FromEnum<EDB_ItemStatus>())
                    .HasMaxLength(DatabaseStandards.ENUM_NAME)
                    .IsRequired(true)
                    .HasComment("Standard Status");
            });

            return modelBuilder;
        }
    }
}
