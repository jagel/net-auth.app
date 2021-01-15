using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSale.Infrastructure.EntityFrameworkDataAccess.ContextConfiguration
{
    internal static class PointOfSaleDbContextExtensions
    {
        public static void SetDynamicModelBuilder(this ModelBuilder modelBuilder)
        {

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IEntityModelBuilder).IsAssignableFrom(p) && p.IsClass)
                .ToList();

            types.ForEach(x =>
            {
                var BuilderObject = (IEntityModelBuilder)Activator.CreateInstance(x);
                modelBuilder = BuilderObject.BuildBaseEntity(modelBuilder);
                modelBuilder = BuilderObject.BuildEntity(modelBuilder);
            });
        }
    }
}
