using Microsoft.Extensions.DependencyInjection;
using PointOfSale.Application.Common;
using PointOfSale.Application.Products;
using PointOfSale.Application.Users;

namespace PointOfSale.Application
{
    public static class ApplicationServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationInitialization(this IServiceCollection services)
        {
            services.AddProductInitialization();
            services.AddUsersInitialization();
            services.AddUnitOfWorkInitialization();
            return services;
        }
    }
}
