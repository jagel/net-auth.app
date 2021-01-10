using domain.Entities.Bases;

namespace pos.Core.Domain.Entities
{
    public class PurchaseProduct : BaseEntitySingle
    {
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }

        public int ProductId { get; set; }
        public int PurchaseSummaryId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Purchase PurchaseSummary { get; set; }
    }
}
