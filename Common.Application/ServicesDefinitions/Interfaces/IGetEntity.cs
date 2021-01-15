using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Application.ServicesDefinitions.Interfaces
{
    public interface IGetEntity<TEntity>
        //,TDbContext> where TDbContext : DbContext
    {
        TEntity Get(int Id);
    }
}
