using Common.Domain.Definitions;
using System;

namespace Common.Domain.EntityBase.Interfaces
{
    public interface IEntityBaseDescriptive
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EDB_ItemStatus Status { get; set; }
    }
}
