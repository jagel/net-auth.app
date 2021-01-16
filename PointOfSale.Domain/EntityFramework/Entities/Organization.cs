using Common.Domain.EntityBase.Enitties;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PointOfSale.Domain.EntityFramework.Entities
{
    public class Organization : EntityBaseDescriptive
    {
        public Organization()
        {
            OrganizationChilds = new HashSet<Organization>();
            OrganizationUsers = new HashSet<OrganizationUser>();
            ProductPrices = new HashSet<ProductPrice>();
            Stocks = new HashSet<Stock>();
        }
        public bool IsPrimary { get; set; }
        public int? OrganizationParentId { get; set; }

        [JsonIgnore]
        public virtual Organization OrganizationParent { get; set; }

        [JsonIgnore]
        public virtual IEnumerable<Organization> OrganizationChilds { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<OrganizationUser> OrganizationUsers { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<ProductPrice> ProductPrices { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<Stock> Stocks { get; set; }
    }
}
