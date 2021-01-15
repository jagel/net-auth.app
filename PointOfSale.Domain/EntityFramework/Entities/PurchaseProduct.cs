
using Common.Domain.EntityBase.Enitties;

namespace PointOfSale.Domain.EntityFramework.Entities
{
    public class PurchaseProduct : EntityBaseBasic
    {
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }

        public int ProductId { get; set; }
        public int PurchaseSummaryId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Purchase PurchaseSummary { get; set; }
    }
}
