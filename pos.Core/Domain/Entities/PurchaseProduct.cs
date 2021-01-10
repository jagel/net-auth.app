using domain.Entities.Bases;

namespace pos.Core.Domain.Entities
{
    public class PurchaseProduct : BaseEntitySingle
    {
        public decimal Price { get; set; }
        public int Amount { get; set; }


        public int ProductId { get; set; }
        public int PurchaseSummaryId { get; set; }

        public virtual Product Product { get; set; }
        public virtual PurchaseSummary PurchaseSummary { get; set; }
    }
}
