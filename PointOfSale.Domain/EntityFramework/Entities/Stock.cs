using Common.Domain.EntityBase.EntityBaseModel;

namespace PointOfSale.Domain.EntityFramework.Entities
{
    public class Stock : EntityBaseAudit
    {
        public int Amount { get; set; }

        public int OrganizationId { get; set; }
        public int ProductId { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual Product Product { get; set; }
    }
}
