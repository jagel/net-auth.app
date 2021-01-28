using Microsoft.Extensions.DependencyInjection;
using PointOfSale.Application.Common.Initialize.Interfaces;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.UnitOfWorks;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.UnitOfWorks.Interfaces;
using PointOfSale.Application.Common.Initialize.Services;

namespace PointOfSale.Application.Common
{
    public static class UnitofWorkInitializeExtension
    {
        public static IServiceCollection AddUnitOfWorkInitialization(this IServiceCollection services)
        {
            services.AddTransient<IInitializePointOfSale, InitializePointOfSale>();

            services.AddTransient<IUOInitialize, UOInitialize>();
            return services;
        }

    }
}
