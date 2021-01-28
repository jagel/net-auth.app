using Common.Infrastructure.EntityFrameworkTools.Repository;
using PointOfSale.Domain.EntityFramework.Entities;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.ContextConfiguration;

namespace PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Products
{
    public class GetAllProducts : GenericRepositoryGetAll<Product, PointOfSaleDbContext>
    {
        public GetAllProducts(PointOfSaleDbContext context) : base(context)
        {
        }
    }
}
