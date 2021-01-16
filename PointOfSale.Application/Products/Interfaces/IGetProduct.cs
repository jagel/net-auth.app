using Common.Infrastructure.EntityFrameworkTools.Repository;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Domain.EntityFramework.Entities;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.ContextConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSale.Application.Products.Interfaces
{
    public class GetProduct : GenericRepositoryGet<Product, PointOfSaleDbContext>
    {
        public GetProduct(PointOfSaleDbContext dbContext): base(dbContext)
        {
        }

        public override async Task<Product> Handler(object IdEntity)
        {
            return await base.context.Product.Where(x=>x.Id == (int)IdEntity).Include(x=>x.Brand).FirstOrDefaultAsync();
        }
    }
}
