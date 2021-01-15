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
    public class BuildBaseEntityAudit<TEntity> : IBaseEntityModelBuilder where TEntity : BaseEntityAudit, new()
    {
        public virtual ModelBuilder BuildBaseEntity(ModelBuilder modelBuilder)
        {
            string EntityName = typeof(TEntity).Name;
            string EntityPKName = $"{EntityName}Id";

            modelBuilder.Entity<TEntity>(entity =>
            {
                entity.Property(x => x.Id)
                    .HasColumnName(EntityPKName)
                    .HasComment($"PK from ${EntityName} is {EntityPKName}");

                entity.HasKey(x => x.Id)
                    .HasName(EntityPKName);

                entity.Property(x => x.Status)
                    .HasDefaultValue(EDB_ItemStatus.Active)
                    .HasMaxLength(DatabaseStandards.ENUM_NAME)
                    .HasConversion(Converters.FromEnum<EDB_ItemStatus>())
                    .IsRequired(true);

                entity.Property(x => x.CreatedDate)
                    .HasColumnType(DatabaseStandards.SQL_DATETIME)
                    .IsRequired(true)
                    .HasDefaultValueSql(DatabaseStandards.SQL_SETCURRENTTIME);

                entity.Property(x => x.UpdatedDate)
                    .HasColumnType(DatabaseStandards.SQL_DATETIME)
                    .IsRequired(false);
            });

            return modelBuilder;
        }
   
    }
}
