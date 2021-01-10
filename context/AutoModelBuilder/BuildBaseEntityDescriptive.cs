using context.Interfaces;
using context.Tools;
using domain.Entities;
using domain.Entities.Bases;
using Microsoft.EntityFrameworkCore;

namespace context.AutoModelBuilder
{
    public class BuildBaseEntityDescriptive<TEntity> : IBaseEntityModelBuilder where TEntity : BaseEntityDescriptive, new()
    {

        public ModelBuilder BuildBaseEntity(ModelBuilder modelBuilder)
        {
            string EntityName = typeof(TEntity).Name;
            string EntityPKName = $"{EntityName}Id";

            modelBuilder.Entity<TEntity>(entity =>
            {
                entity.Property(x => x.Id)
                    .HasColumnName(EntityName)
                    .HasComment($"Primary key");

                entity.HasKey(x => x.Id)
                    .HasName(EntityPKName);

                entity.Property(x => x.Name)
                    .IsRequired(true)
                    .IsUnicode(false)
                    .HasMaxLength(DatabaseStandards.NAME_LENGHT)
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
                    .IsRequired(true)
                    .HasMaxLength(DatabaseStandards.ENUM_NAME)
                    .HasComment("Standard Status");

            });

            return modelBuilder;
        }
    }
}
