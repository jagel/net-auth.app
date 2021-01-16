using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infrastructure.EntityFrameworkTools.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : class, new()
    {
        Task<TEntity> Handler(object IdEntity);
    }
}
