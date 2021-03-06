﻿using Common.Domain.Definitions;
using Common.Domain.EntityBase.Enitties;
using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Common.Infrastructure.EntityFrameworkTools.Tools;
using Microsoft.EntityFrameworkCore;

namespace Common.Infrastructure.EntityFrameworkTools.EntityBases
{
    public class BuildBaseEntityDescriptive<TEntity> : IBaseEntityModelBuilder where TEntity : EntityBaseDescriptive, new()
    {

        public ModelBuilder BuildBaseEntity(ModelBuilder modelBuilder)
        {
            string EntityName = typeof(TEntity).Name;
            string EntityPKName = $"{EntityName}Id";

            modelBuilder.Entity<TEntity>(entity =>
            {
                entity.Property(x => x.Id)
                    .HasColumnName(EntityPKName)
                    .HasComment($"Primary key");

                entity.HasKey(x => x.Id)
                    .HasName(EntityPKName);

                entity.Property(x => x.Name)
                    .IsRequired(true)
                    .IsUnicode(false)
                    .HasComment("Name");

                entity.Property(x => x.Description)
                    .IsRequired(false)
                    .IsUnicode(false)
                    .HasMaxLength(DatabaseStandards.DESCRIPTION_LENGHT)
                    .HasComment("Description");

                entity.Property(x => x.CreatedDate)
                    .HasColumnType("datetime2")
                    .IsRequired()
                    .HasComment("Created date")
                    .HasDefaultValueSql(DatabaseStandards.SQL_SETCURRENTTIME);

                entity.Property(x => x.UpdatedDate)
                    .HasColumnType(DatabaseStandards.SQL_DATETIME)
                    .IsRequired(false)
                    .HasComment("Updated date");

                entity.Property(x => x.Status)
                    .HasDefaultValue(EDB_ItemStatus.Active)
                    .HasConversion(Converters.FromEnum<EDB_ItemStatus>())
                    .HasMaxLength(DatabaseStandards.ENUM_NAME)
                    .IsRequired(true)
                    .HasMaxLength(DatabaseStandards.ENUM_NAME)
                    .HasComment("Standard Status");

            });

            return modelBuilder;
        }
    }
}
