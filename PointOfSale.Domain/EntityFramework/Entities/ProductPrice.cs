using Common.Domain.EntityBase.EntityBaseModel;

namespace PointOfSale.Domain.EntityFramework.Entities
{
    public class ProductPrice : EntityBaseAudit
    {
        public decimal UnitPrice { get; set; }
        public bool IsCurrentPrice { get; set; }

        public int OrganizationId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Organization Organization { get; set; }
    }
}