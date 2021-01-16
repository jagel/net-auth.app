using Common.Domain.EntityBase.EntityBaseModel;
using System.Text.Json.Serialization;

namespace PointOfSale.Domain.EntityFramework.Entities
{
    public class ProductPrice : EntityBaseAudit
    {
        public decimal UnitPrice { get; set; }
        public bool IsCurrentPrice { get; set; }

        public int OrganizationId { get; set; }
        public int ProductId { get; set; }


        [JsonIgnore]
        public virtual Product Product { get; set; }
        [JsonIgnore]
        public virtual Organization Organization { get; set; }
    }
}