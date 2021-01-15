using Common.Domain.Definitions;
using Common.Domain.EntityBase.Interfaces;
using System;

namespace Common.Domain.EntityBase.EntityBaseModel
{
    public class EntityBaseAudit : IEntityBaseAudit
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public EDB_ItemStatus Status { get; set; }
    }
}
