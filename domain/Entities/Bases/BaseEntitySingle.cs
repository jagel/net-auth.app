using domain.Application;
using domain.Entities.Interfaces;

namespace domain.Entities.Bases
{
    public class BaseEntitySingle : IBaseEntitySingle
    {
        public int Id  { get; set; }
        public EDB_ItemStatus Status { get; set; }
    }
}
