using Common.Domain.EntityBase.Enitties;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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

        
        [JsonIgnore]
        public virtual CatalogItem Brand { get; set; }

        
        [JsonIgnore]
        public virtual IEnumerable<ProductPrice> ProductPrices { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<PurchaseProduct> PurchaseProducts { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<Stock> Stocks { get; set; }
    }
}
