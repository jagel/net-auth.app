
using Common.Domain.EntityBase.Enitties;
using System.Text.Json.Serialization;

namespace PointOfSale.Domain.EntityFramework.Entities
{
    public class PurchaseProduct : EntityBaseBasic
    {
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }

        public int ProductId { get; set; }
        public int PurchaseSummaryId { get; set; }

        [JsonIgnore]
        public virtual Product Product { get; set; }
        [JsonIgnore]
        public virtual Purchase PurchaseSummary { get; set; }
    }
}
