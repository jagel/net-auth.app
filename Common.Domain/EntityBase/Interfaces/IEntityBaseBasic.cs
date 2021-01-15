using Common.Domain.Definitions;

namespace Common.Domain.EntityBase.Interfaces
{
    public interface IEntityBaseBasic
    {
        public int Id { get; set; }
        public EDB_ItemStatus Status { get; set; }
    }
}
