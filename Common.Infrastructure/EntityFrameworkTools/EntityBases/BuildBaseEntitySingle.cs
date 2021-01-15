using Common.Domain.Definitions;
using Common.Domain.EntityBase.Enitties;
using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Common.Infrastructure.EntityFrameworkTools.Tools;
using Microsoft.EntityFrameworkCore;

namespace Common.Infrastructure.EntityFrameworkTools.EntityBases
{
    public class BuildBaseEntitySingle<TEntity> : IBaseEntityModelBuilder where TEntity : EntityBaseBasic, new()
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
