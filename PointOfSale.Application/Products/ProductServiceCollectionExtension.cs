using Common.Infrastructure.EntityFrameworkTools.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using PointOfSale.Domain.EntityFramework.Entities;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Products;

namespace PointOfSale.Application.Products
{
    public static class ProductServiceCollectionExtension
    {
        public static IServiceCollection AddProductInitialization(this IServiceCollection services)
        {
            services.AddTransient<IRepositoryGetById<Product>, GetProductById>();
            services.AddTransient<IRepositoryGetAll<Product>, GetAllProducts>();
            return services;
        }
    }
}
