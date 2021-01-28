using System.Linq;
using System.Threading.Tasks;

namespace Common.Infrastructure.EntityFrameworkTools.Interfaces
{
    public interface IRepositoryGetAll<TEntity>
        where TEntity : class, new()
    {
        Task<IQueryable<TEntity>> Handler();
    }
}
