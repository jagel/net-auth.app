using Common.Infrastructure.EntityFrameworkTools.Repository;
using PointOfSale.Domain.EntityFramework.Entities;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.ContextConfiguration;
using PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Organizations.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Organizations

{
    public class GetOrganizationRepository : BaseGenericRepository<PointOfSaleDbContext>, IGetOrganizationRespository
    {
        public GetOrganizationRepository(PointOfSaleDbContext context) : base(context)
        {

        }
        public IQueryable<Organization> GetOrganizationById(int Id) =>
            base.context.Organization.Where(x=>x.Id == Id);

        public IQueryable<Organization> GetOrganizationByGuid(Guid guid) =>
            base.context.Organization.Where(x => x.Token == guid);
        

    }
}
