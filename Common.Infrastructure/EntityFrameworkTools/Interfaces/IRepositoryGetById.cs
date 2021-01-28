using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infrastructure.EntityFrameworkTools.Interfaces
{
    public interface IRepositoryGetById<TEntity>
        where TEntity : class, new()
    {
        Task<TEntity> Handler(object IdEntity);
    }
}
