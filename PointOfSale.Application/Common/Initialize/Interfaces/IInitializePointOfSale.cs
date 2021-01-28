using System.Threading.Tasks;

namespace PointOfSale.Application.Common.Initialize.Interfaces
{
    public interface IInitializePointOfSale
    {
        Task InitializeDatabase();
    }
}
