using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Infrastructure.EntityFrameworkTools.Interfaces
{
    public interface IRepositoryCreate<TEntity>
        where TEntity : class, new()
    {
        Task<TEntity> Handler(TEntity entity);
        Task<ICollection<TEntity>> Handler(ICollection<TEntity> entity);
    }
}
