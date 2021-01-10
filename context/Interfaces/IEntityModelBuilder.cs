using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace context.Interfaces
{
    public interface IBaseEntityModelBuilder
    {
        ModelBuilder BuildBaseEntity(ModelBuilder modelBuilder);
    }

    public interface IEntityModelBuilder : IBaseEntityModelBuilder
    {
        ModelBuilder BuildEntity(ModelBuilder modelBuilder);
    }
}
