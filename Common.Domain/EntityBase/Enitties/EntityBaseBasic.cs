using Common.Domain.Definitions;
using Common.Domain.EntityBase.Interfaces;

namespace Common.Domain.EntityBase.Enitties
{
    public class EntityBaseBasic : IEntityBaseBasic
    {
        public int Id { get; set; }
        public EDB_ItemStatus Status { get; set; }
    }
}
