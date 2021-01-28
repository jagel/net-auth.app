using Common.Domain.EntityBase.EntityBaseModel;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PointOfSale.Domain.EntityFramework.Entities
{
    public class User : EntityBaseAudit
    {
        public User()
        {
            OrganizationUsers = new HashSet<OrganizationUser>();
            Purchases = new HashSet<Purchase>();
        }

        public string UserName { get; set; }
        public string Token { get; set; }
        [JsonIgnore]
        public string Pasword { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public DateTime ExpirationDate { get; set; }

        [JsonIgnore]
        public virtual IEnumerable<OrganizationUser> OrganizationUsers { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<Purchase> Purchases { get; set; }
    }
}
