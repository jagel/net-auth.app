using Common.Domain.EntityBase.Enitties;
using System.Collections.Generic;

namespace PointOfSale.Domain.EntityFramework.Entities
{
    public class Product : EntityBaseDescriptive
    {
        public Product()
        {
            ProductPrices = new HashSet<ProductPrice>();
            PurchaseProducts = new HashSet<PurchaseProduct>();
            Stocks = new HashSet<Stock>();
        }
        public string Barcode { get; set; }
        public string Reference { get; set; }

        public int BrandId { get; set; }

        
        public virtual CatalogItem Brand { get; set; }


        public virtual IEnumerable<ProductPrice> ProductPrices { get; set; }
        public virtual IEnumerable<PurchaseProduct> PurchaseProducts { get; set; }
        public virtual IEnumerable<Stock> Stocks { get; set; }
    }
}
