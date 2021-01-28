using PointOfSale.Domain.EntityFramework.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfSale.Infrastructure.EntityFrameworkDataAccess.Repositories.Organizations.Interfaces
{
    public interface IGetOrganizationRespository
    {
        IQueryable<Organization> GetOrganizationById(int Id);
        IQueryable<Organization> GetOrganizationByGuid(Guid guid);
    }
}
