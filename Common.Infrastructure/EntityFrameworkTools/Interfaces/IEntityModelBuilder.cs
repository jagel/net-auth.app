using Microsoft.EntityFrameworkCore;

namespace Common.Infrastructure.EntityFrameworkTools.Interfaces
{
    public interface IEntityModelBuilder : IBaseEntityModelBuilder
    {
        ModelBuilder BuildEntity(ModelBuilder modelBuilder);
    }
}
