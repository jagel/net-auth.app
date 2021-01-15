using Microsoft.EntityFrameworkCore;

namespace Common.Infrastructure.EntityFrameworkTools.Interfaces
{
    public interface IBaseEntityModelBuilder
    {
        ModelBuilder BuildBaseEntity(ModelBuilder modelBuilder);
    }
}
