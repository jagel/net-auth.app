using Common.Domain.Definitions;
using Common.Domain.EntityBase.Interfaces;
using System;

namespace Common.Domain.EntityBase.Enitties
{
    public class EntityBaseDescriptive : IEntityBaseDescriptive
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EDB_ItemStatus Status { get; set; }
    }
}
