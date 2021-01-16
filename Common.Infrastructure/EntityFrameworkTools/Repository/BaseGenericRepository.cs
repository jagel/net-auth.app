using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Infrastructure.EntityFrameworkTools.Repository
{
    public class BaseGenericRepository<TDbcontext>
        where TDbcontext : DbContext
    {
        protected TDbcontext context;
        public BaseGenericRepository(TDbcontext context)
        {
            this.context = context;
        }
    }
}
