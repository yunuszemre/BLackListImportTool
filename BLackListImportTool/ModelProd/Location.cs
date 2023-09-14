using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class Location
    {
        public Location()
        {
            AccountCarrierBlacklists = new HashSet<AccountCarrierBlacklist>();
            AccountDecisionRules = new HashSet<AccountDecisionRule>();
            AccountServiceTypeRules = new HashSet<AccountServiceTypeRule>();
            Addresses = new HashSet<Address>();
            ConsignmentDetails = new HashSet<ConsignmentDetail>();
            Customers = new HashSet<Customer>();
            IntegrationHistories = new HashSet<IntegrationHistory>();
            LocationCarrierConfigurations = new HashSet<LocationCarrierConfiguration>();
            ProductConfigurations = new HashSet<ProductConfiguration>();
            RouteLocations = new HashSet<RouteLocation>();
            Shipments = new HashSet<Shipment>();
            StoreUsers = new HashSet<StoreUser>();
            UserIdentityLocations = new HashSet<UserIdentityLocation>();
        }

        public long LocationId { get; set; }
        public long AccountId { get; set; }
        public long ClientId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long LocationTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public bool? IsWareHouse { get; set; }
        public long? ParentLocationId { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual UserIdentity? ChangeUserIdentity { get; set; }
        public virtual Client Client { get; set; } = null!;
        public virtual UserIdentity CreateUserIdentity { get; set; } = null!;
        public virtual TypeLookup LocationType { get; set; } = null!;
        public virtual ICollection<AccountCarrierBlacklist> AccountCarrierBlacklists { get; set; }
        public virtual ICollection<AccountDecisionRule> AccountDecisionRules { get; set; }
        public virtual ICollection<AccountServiceTypeRule> AccountServiceTypeRules { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<ConsignmentDetail> ConsignmentDetails { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<IntegrationHistory> IntegrationHistories { get; set; }
        public virtual ICollection<LocationCarrierConfiguration> LocationCarrierConfigurations { get; set; }
        public virtual ICollection<ProductConfiguration> ProductConfigurations { get; set; }
        public virtual ICollection<RouteLocation> RouteLocations { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<StoreUser> StoreUsers { get; set; }
        public virtual ICollection<UserIdentityLocation> UserIdentityLocations { get; set; }
    }
}
