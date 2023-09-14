using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class UserIdentity
    {
        public UserIdentity()
        {
            AccountCarrierBlacklistChangeUserIdentities = new HashSet<AccountCarrierBlacklist>();
            AccountCarrierBlacklistCreateUserIdentities = new HashSet<AccountCarrierBlacklist>();
            AccountCarrierDistanceDesiCostChangeUserIdentities = new HashSet<AccountCarrierDistanceDesiCost>();
            AccountCarrierDistanceDesiCostCreateUserIdentities = new HashSet<AccountCarrierDistanceDesiCost>();
            AccountCarrierPlannedShipmentConfigurationChangeUserIdentities = new HashSet<AccountCarrierPlannedShipmentConfiguration>();
            AccountCarrierPlannedShipmentConfigurationCreateUserIdentities = new HashSet<AccountCarrierPlannedShipmentConfiguration>();
            AccountChangeUserIdentities = new HashSet<Account>();
            AccountCreateUserIdentities = new HashSet<Account>();
            AccountCriteriaPriorityMappingChangeUserIdentities = new HashSet<AccountCriteriaPriorityMapping>();
            AccountCriteriaPriorityMappingCreateUserIdentities = new HashSet<AccountCriteriaPriorityMapping>();
            AccountDecisionRuleChangeUserIdentities = new HashSet<AccountDecisionRule>();
            AccountDecisionRuleCreateUserIdentities = new HashSet<AccountDecisionRule>();
            AccountLocationWorkingScheduleChangeUserIdentities = new HashSet<AccountLocationWorkingSchedule>();
            AccountLocationWorkingScheduleCreateUserIdentities = new HashSet<AccountLocationWorkingSchedule>();
            AccountSalesChannelConfigurationChangeUserIdentities = new HashSet<AccountSalesChannelConfiguration>();
            AccountSalesChannelConfigurationCreateUserIdentities = new HashSet<AccountSalesChannelConfiguration>();
            AccountServiceTypeRuleChangeUserIdentities = new HashSet<AccountServiceTypeRule>();
            AccountServiceTypeRuleCreateUserIdentities = new HashSet<AccountServiceTypeRule>();
            AddressChangeUserIdentities = new HashSet<Address>();
            AddressCreateUserIdentities = new HashSet<Address>();
            CarDrivers = new HashSet<CarDriver>();
            CarrierChangeUserIdentities = new HashSet<Carrier>();
            CarrierCreateUserIdentities = new HashSet<Carrier>();
            CarrierDeliveryTypeChangeUserIdentities = new HashSet<CarrierDeliveryType>();
            CarrierDeliveryTypeCreateUserIdentities = new HashSet<CarrierDeliveryType>();
            CarrierDistanceBetweenCityGroupChangeUserIdentities = new HashSet<CarrierDistanceBetweenCityGroup>();
            CarrierDistanceBetweenCityGroupCreateUserIdentities = new HashSet<CarrierDistanceBetweenCityGroup>();
            CarrierDistanceLookupChangeUserIdentities = new HashSet<CarrierDistanceLookup>();
            CarrierDistanceLookupCreateUserIdentities = new HashSet<CarrierDistanceLookup>();
            CarrierRouteMappingChangeUserIdentities = new HashSet<CarrierRouteMapping>();
            CarrierRouteMappingCreateUserIdentities = new HashSet<CarrierRouteMapping>();
            CarrierRouteMappingMobileBranchChangeUserIdentities = new HashSet<CarrierRouteMappingMobileBranch>();
            CarrierRouteMappingMobileBranchCreateUserIdentities = new HashSet<CarrierRouteMappingMobileBranch>();
            CarrierShipmentStatusChangeUserIdentities = new HashSet<CarrierShipmentStatus>();
            CarrierShipmentStatusCreateUserIdentities = new HashSet<CarrierShipmentStatus>();
            CarrierShipmentStatusNotMatchChangeUserIdentities = new HashSet<CarrierShipmentStatusNotMatch>();
            CarrierShipmentStatusNotMatchCreateUserIdentities = new HashSet<CarrierShipmentStatusNotMatch>();
            CarrierValueMappingChangeUserIdentities = new HashSet<CarrierValueMapping>();
            CarrierValueMappingCreateUserIdentities = new HashSet<CarrierValueMapping>();
            CityChangeUserIdentities = new HashSet<City>();
            CityCreateUserIdentities = new HashSet<City>();
            ClientChangeUserIdentities = new HashSet<Client>();
            ClientCreateUserIdentities = new HashSet<Client>();
            ClientValueMappingChangeUserIdentities = new HashSet<ClientValueMapping>();
            ClientValueMappingCreateUserIdentities = new HashSet<ClientValueMapping>();
            ConsignmentConfigurationChangeUserIdentities = new HashSet<ConsignmentConfiguration>();
            ConsignmentConfigurationCreateUserIdentities = new HashSet<ConsignmentConfiguration>();
            ConsignmentDetailChangeUserIdentities = new HashSet<ConsignmentDetail>();
            ConsignmentDetailCreateUserIdentities = new HashSet<ConsignmentDetail>();
            CountryChangeUserIdentities = new HashSet<Country>();
            CountryCreateUserIdentities = new HashSet<Country>();
            CustomerChangeUserIdentities = new HashSet<Customer>();
            CustomerCreateUserIdentities = new HashSet<Customer>();
            CustomerSegmentChangeUserIdentities = new HashSet<CustomerSegment>();
            CustomerSegmentCreateUserIdentities = new HashSet<CustomerSegment>();
            DistrictChangeUserIdentities = new HashSet<District>();
            DistrictCreateUserIdentities = new HashSet<District>();
            DocumentTemplateChangeUserIdentities = new HashSet<DocumentTemplate>();
            DocumentTemplateCreateUserIdentities = new HashSet<DocumentTemplate>();
            IntegrationHistoryChangeUserIdentities = new HashSet<IntegrationHistory>();
            IntegrationHistoryCreateUserIdentities = new HashSet<IntegrationHistory>();
            InverseChangeUserIdentity = new HashSet<UserIdentity>();
            InverseCreateUserIdentity = new HashSet<UserIdentity>();
            JobTrackingChangeUserIdentities = new HashSet<JobTracking>();
            JobTrackingCreateUserIdentities = new HashSet<JobTracking>();
            LocationCarrierConfigurationChangeUserIdentities = new HashSet<LocationCarrierConfiguration>();
            LocationCarrierConfigurationCreateUserIdentities = new HashSet<LocationCarrierConfiguration>();
            LocationChangeUserIdentities = new HashSet<Location>();
            LocationCreateUserIdentities = new HashSet<Location>();
            OperationClaimChangeUserIdentities = new HashSet<OperationClaim>();
            OperationClaimCreateUserIdentities = new HashSet<OperationClaim>();
            OperationRoleChangeUserIdentities = new HashSet<OperationRole>();
            OperationRoleCreateUserIdentities = new HashSet<OperationRole>();
            OperationRoleOperationClaimChangeUserIdentities = new HashSet<OperationRoleOperationClaim>();
            OperationRoleOperationClaimCreateUserIdentities = new HashSet<OperationRoleOperationClaim>();
            OrderChangeUserIdentities = new HashSet<Order>();
            OrderCreateUserIdentities = new HashSet<Order>();
            PlannedShipmentWorkingScheduleChangeUserIdentities = new HashSet<PlannedShipmentWorkingSchedule>();
            PlannedShipmentWorkingScheduleCreateUserIdentities = new HashSet<PlannedShipmentWorkingSchedule>();
            ProcessGroupChangeUserIdentities = new HashSet<ProcessGroup>();
            ProcessGroupCreateUserIdentities = new HashSet<ProcessGroup>();
            ProductConfigurationChangeUserIdentities = new HashSet<ProductConfiguration>();
            ProductConfigurationCreateUserIdentities = new HashSet<ProductConfiguration>();
            ReportHistoryChangeUserIdentities = new HashSet<ReportHistory>();
            ReportHistoryCreateUserIdentities = new HashSet<ReportHistory>();
            ReportScriptChangeUserIdentities = new HashSet<ReportScript>();
            ReportScriptCreateUserIdentities = new HashSet<ReportScript>();
            ReportScriptParameterChangeUserIdentities = new HashSet<ReportScriptParameter>();
            ReportScriptParameterCreateUserIdentities = new HashSet<ReportScriptParameter>();
            ReturnChangeUserIdentities = new HashSet<Return>();
            ReturnCreateUserIdentities = new HashSet<Return>();
            SalesChannelChangeUserIdentities = new HashSet<SalesChannel>();
            SalesChannelCreateUserIdentities = new HashSet<SalesChannel>();
            SegmentChangeUserIdentities = new HashSet<Segment>();
            SegmentCreateUserIdentities = new HashSet<Segment>();
            ShipmentCarrierHistoryChangeUserIdentities = new HashSet<ShipmentCarrierHistory>();
            ShipmentCarrierHistoryCreateUserIdentities = new HashSet<ShipmentCarrierHistory>();
            ShipmentChangeUserIdentities = new HashSet<Shipment>();
            ShipmentCreateUserIdentities = new HashSet<Shipment>();
            ShipmentDeliveryReceipts = new HashSet<ShipmentDeliveryReceipt>();
            ShipmentDetailChangeUserIdentities = new HashSet<ShipmentDetail>();
            ShipmentDetailCreateUserIdentities = new HashSet<ShipmentDetail>();
            ShipmentDocumentChangeUserIdentities = new HashSet<ShipmentDocument>();
            ShipmentDocumentCreateUserIdentities = new HashSet<ShipmentDocument>();
            ShipmentHistoryChangeUserIdentities = new HashSet<ShipmentHistory>();
            ShipmentHistoryCreateUserIdentities = new HashSet<ShipmentHistory>();
            ShipmentStatusMappingChangeUserIdentities = new HashSet<ShipmentStatusMapping>();
            ShipmentStatusMappingCreateUserIdentities = new HashSet<ShipmentStatusMapping>();
            StatusLookupChangeUserIdentities = new HashSet<StatusLookup>();
            StatusLookupCreateUserIdentities = new HashSet<StatusLookup>();
            StoreUsers = new HashSet<StoreUser>();
            TownChangeUserIdentities = new HashSet<Town>();
            TownCreateUserIdentities = new HashSet<Town>();
            TypeLookupChangeUserIdentities = new HashSet<TypeLookup>();
            TypeLookupCreateUserIdentities = new HashSet<TypeLookup>();
            UserIdentityAccountChangeUserIdentities = new HashSet<UserIdentityAccount>();
            UserIdentityAccountCreateUserIdentities = new HashSet<UserIdentityAccount>();
            UserIdentityAccountUserIdentities = new HashSet<UserIdentityAccount>();
            UserIdentityClientChangeUserIdentities = new HashSet<UserIdentityClient>();
            UserIdentityClientCreateUserIdentities = new HashSet<UserIdentityClient>();
            UserIdentityClientUserIdentities = new HashSet<UserIdentityClient>();
            UserIdentityLocationChangeUserIdentities = new HashSet<UserIdentityLocation>();
            UserIdentityLocationCreateUserIdentities = new HashSet<UserIdentityLocation>();
            UserIdentityLocationUserIdentities = new HashSet<UserIdentityLocation>();
            UserIdentityOperationClaimChangeUserIdentities = new HashSet<UserIdentityOperationClaim>();
            UserIdentityOperationClaimCreateUserIdentities = new HashSet<UserIdentityOperationClaim>();
            UserIdentityOperationClaimUserIdentities = new HashSet<UserIdentityOperationClaim>();
            UserIdentityOperationRoleChangeUserIdentities = new HashSet<UserIdentityOperationRole>();
            UserIdentityOperationRoleCreateUserIdentities = new HashSet<UserIdentityOperationRole>();
            UserIdentityOperationRoleUserIdentities = new HashSet<UserIdentityOperationRole>();
        }

        public long UserIdentityId { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public byte[]? PasswordHash { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }
        public long? LastLoggedInClientId { get; set; }
        public long? LastLoggedInAccountId { get; set; }
        public long? LastLoggedInLocationId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public string? IdentityNumber { get; set; }
        public string? PhoneNumber { get; set; }

        public virtual UserIdentity? ChangeUserIdentity { get; set; }
        public virtual UserIdentity CreateUserIdentity { get; set; } = null!;
        public virtual ICollection<AccountCarrierBlacklist> AccountCarrierBlacklistChangeUserIdentities { get; set; }
        public virtual ICollection<AccountCarrierBlacklist> AccountCarrierBlacklistCreateUserIdentities { get; set; }
        public virtual ICollection<AccountCarrierDistanceDesiCost> AccountCarrierDistanceDesiCostChangeUserIdentities { get; set; }
        public virtual ICollection<AccountCarrierDistanceDesiCost> AccountCarrierDistanceDesiCostCreateUserIdentities { get; set; }
        public virtual ICollection<AccountCarrierPlannedShipmentConfiguration> AccountCarrierPlannedShipmentConfigurationChangeUserIdentities { get; set; }
        public virtual ICollection<AccountCarrierPlannedShipmentConfiguration> AccountCarrierPlannedShipmentConfigurationCreateUserIdentities { get; set; }
        public virtual ICollection<Account> AccountChangeUserIdentities { get; set; }
        public virtual ICollection<Account> AccountCreateUserIdentities { get; set; }
        public virtual ICollection<AccountCriteriaPriorityMapping> AccountCriteriaPriorityMappingChangeUserIdentities { get; set; }
        public virtual ICollection<AccountCriteriaPriorityMapping> AccountCriteriaPriorityMappingCreateUserIdentities { get; set; }
        public virtual ICollection<AccountDecisionRule> AccountDecisionRuleChangeUserIdentities { get; set; }
        public virtual ICollection<AccountDecisionRule> AccountDecisionRuleCreateUserIdentities { get; set; }
        public virtual ICollection<AccountLocationWorkingSchedule> AccountLocationWorkingScheduleChangeUserIdentities { get; set; }
        public virtual ICollection<AccountLocationWorkingSchedule> AccountLocationWorkingScheduleCreateUserIdentities { get; set; }
        public virtual ICollection<AccountSalesChannelConfiguration> AccountSalesChannelConfigurationChangeUserIdentities { get; set; }
        public virtual ICollection<AccountSalesChannelConfiguration> AccountSalesChannelConfigurationCreateUserIdentities { get; set; }
        public virtual ICollection<AccountServiceTypeRule> AccountServiceTypeRuleChangeUserIdentities { get; set; }
        public virtual ICollection<AccountServiceTypeRule> AccountServiceTypeRuleCreateUserIdentities { get; set; }
        public virtual ICollection<Address> AddressChangeUserIdentities { get; set; }
        public virtual ICollection<Address> AddressCreateUserIdentities { get; set; }
        public virtual ICollection<CarDriver> CarDrivers { get; set; }
        public virtual ICollection<Carrier> CarrierChangeUserIdentities { get; set; }
        public virtual ICollection<Carrier> CarrierCreateUserIdentities { get; set; }
        public virtual ICollection<CarrierDeliveryType> CarrierDeliveryTypeChangeUserIdentities { get; set; }
        public virtual ICollection<CarrierDeliveryType> CarrierDeliveryTypeCreateUserIdentities { get; set; }
        public virtual ICollection<CarrierDistanceBetweenCityGroup> CarrierDistanceBetweenCityGroupChangeUserIdentities { get; set; }
        public virtual ICollection<CarrierDistanceBetweenCityGroup> CarrierDistanceBetweenCityGroupCreateUserIdentities { get; set; }
        public virtual ICollection<CarrierDistanceLookup> CarrierDistanceLookupChangeUserIdentities { get; set; }
        public virtual ICollection<CarrierDistanceLookup> CarrierDistanceLookupCreateUserIdentities { get; set; }
        public virtual ICollection<CarrierRouteMapping> CarrierRouteMappingChangeUserIdentities { get; set; }
        public virtual ICollection<CarrierRouteMapping> CarrierRouteMappingCreateUserIdentities { get; set; }
        public virtual ICollection<CarrierRouteMappingMobileBranch> CarrierRouteMappingMobileBranchChangeUserIdentities { get; set; }
        public virtual ICollection<CarrierRouteMappingMobileBranch> CarrierRouteMappingMobileBranchCreateUserIdentities { get; set; }
        public virtual ICollection<CarrierShipmentStatus> CarrierShipmentStatusChangeUserIdentities { get; set; }
        public virtual ICollection<CarrierShipmentStatus> CarrierShipmentStatusCreateUserIdentities { get; set; }
        public virtual ICollection<CarrierShipmentStatusNotMatch> CarrierShipmentStatusNotMatchChangeUserIdentities { get; set; }
        public virtual ICollection<CarrierShipmentStatusNotMatch> CarrierShipmentStatusNotMatchCreateUserIdentities { get; set; }
        public virtual ICollection<CarrierValueMapping> CarrierValueMappingChangeUserIdentities { get; set; }
        public virtual ICollection<CarrierValueMapping> CarrierValueMappingCreateUserIdentities { get; set; }
        public virtual ICollection<City> CityChangeUserIdentities { get; set; }
        public virtual ICollection<City> CityCreateUserIdentities { get; set; }
        public virtual ICollection<Client> ClientChangeUserIdentities { get; set; }
        public virtual ICollection<Client> ClientCreateUserIdentities { get; set; }
        public virtual ICollection<ClientValueMapping> ClientValueMappingChangeUserIdentities { get; set; }
        public virtual ICollection<ClientValueMapping> ClientValueMappingCreateUserIdentities { get; set; }
        public virtual ICollection<ConsignmentConfiguration> ConsignmentConfigurationChangeUserIdentities { get; set; }
        public virtual ICollection<ConsignmentConfiguration> ConsignmentConfigurationCreateUserIdentities { get; set; }
        public virtual ICollection<ConsignmentDetail> ConsignmentDetailChangeUserIdentities { get; set; }
        public virtual ICollection<ConsignmentDetail> ConsignmentDetailCreateUserIdentities { get; set; }
        public virtual ICollection<Country> CountryChangeUserIdentities { get; set; }
        public virtual ICollection<Country> CountryCreateUserIdentities { get; set; }
        public virtual ICollection<Customer> CustomerChangeUserIdentities { get; set; }
        public virtual ICollection<Customer> CustomerCreateUserIdentities { get; set; }
        public virtual ICollection<CustomerSegment> CustomerSegmentChangeUserIdentities { get; set; }
        public virtual ICollection<CustomerSegment> CustomerSegmentCreateUserIdentities { get; set; }
        public virtual ICollection<District> DistrictChangeUserIdentities { get; set; }
        public virtual ICollection<District> DistrictCreateUserIdentities { get; set; }
        public virtual ICollection<DocumentTemplate> DocumentTemplateChangeUserIdentities { get; set; }
        public virtual ICollection<DocumentTemplate> DocumentTemplateCreateUserIdentities { get; set; }
        public virtual ICollection<IntegrationHistory> IntegrationHistoryChangeUserIdentities { get; set; }
        public virtual ICollection<IntegrationHistory> IntegrationHistoryCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentity> InverseChangeUserIdentity { get; set; }
        public virtual ICollection<UserIdentity> InverseCreateUserIdentity { get; set; }
        public virtual ICollection<JobTracking> JobTrackingChangeUserIdentities { get; set; }
        public virtual ICollection<JobTracking> JobTrackingCreateUserIdentities { get; set; }
        public virtual ICollection<LocationCarrierConfiguration> LocationCarrierConfigurationChangeUserIdentities { get; set; }
        public virtual ICollection<LocationCarrierConfiguration> LocationCarrierConfigurationCreateUserIdentities { get; set; }
        public virtual ICollection<Location> LocationChangeUserIdentities { get; set; }
        public virtual ICollection<Location> LocationCreateUserIdentities { get; set; }
        public virtual ICollection<OperationClaim> OperationClaimChangeUserIdentities { get; set; }
        public virtual ICollection<OperationClaim> OperationClaimCreateUserIdentities { get; set; }
        public virtual ICollection<OperationRole> OperationRoleChangeUserIdentities { get; set; }
        public virtual ICollection<OperationRole> OperationRoleCreateUserIdentities { get; set; }
        public virtual ICollection<OperationRoleOperationClaim> OperationRoleOperationClaimChangeUserIdentities { get; set; }
        public virtual ICollection<OperationRoleOperationClaim> OperationRoleOperationClaimCreateUserIdentities { get; set; }
        public virtual ICollection<Order> OrderChangeUserIdentities { get; set; }
        public virtual ICollection<Order> OrderCreateUserIdentities { get; set; }
        public virtual ICollection<PlannedShipmentWorkingSchedule> PlannedShipmentWorkingScheduleChangeUserIdentities { get; set; }
        public virtual ICollection<PlannedShipmentWorkingSchedule> PlannedShipmentWorkingScheduleCreateUserIdentities { get; set; }
        public virtual ICollection<ProcessGroup> ProcessGroupChangeUserIdentities { get; set; }
        public virtual ICollection<ProcessGroup> ProcessGroupCreateUserIdentities { get; set; }
        public virtual ICollection<ProductConfiguration> ProductConfigurationChangeUserIdentities { get; set; }
        public virtual ICollection<ProductConfiguration> ProductConfigurationCreateUserIdentities { get; set; }
        public virtual ICollection<ReportHistory> ReportHistoryChangeUserIdentities { get; set; }
        public virtual ICollection<ReportHistory> ReportHistoryCreateUserIdentities { get; set; }
        public virtual ICollection<ReportScript> ReportScriptChangeUserIdentities { get; set; }
        public virtual ICollection<ReportScript> ReportScriptCreateUserIdentities { get; set; }
        public virtual ICollection<ReportScriptParameter> ReportScriptParameterChangeUserIdentities { get; set; }
        public virtual ICollection<ReportScriptParameter> ReportScriptParameterCreateUserIdentities { get; set; }
        public virtual ICollection<Return> ReturnChangeUserIdentities { get; set; }
        public virtual ICollection<Return> ReturnCreateUserIdentities { get; set; }
        public virtual ICollection<SalesChannel> SalesChannelChangeUserIdentities { get; set; }
        public virtual ICollection<SalesChannel> SalesChannelCreateUserIdentities { get; set; }
        public virtual ICollection<Segment> SegmentChangeUserIdentities { get; set; }
        public virtual ICollection<Segment> SegmentCreateUserIdentities { get; set; }
        public virtual ICollection<ShipmentCarrierHistory> ShipmentCarrierHistoryChangeUserIdentities { get; set; }
        public virtual ICollection<ShipmentCarrierHistory> ShipmentCarrierHistoryCreateUserIdentities { get; set; }
        public virtual ICollection<Shipment> ShipmentChangeUserIdentities { get; set; }
        public virtual ICollection<Shipment> ShipmentCreateUserIdentities { get; set; }
        public virtual ICollection<ShipmentDeliveryReceipt> ShipmentDeliveryReceipts { get; set; }
        public virtual ICollection<ShipmentDetail> ShipmentDetailChangeUserIdentities { get; set; }
        public virtual ICollection<ShipmentDetail> ShipmentDetailCreateUserIdentities { get; set; }
        public virtual ICollection<ShipmentDocument> ShipmentDocumentChangeUserIdentities { get; set; }
        public virtual ICollection<ShipmentDocument> ShipmentDocumentCreateUserIdentities { get; set; }
        public virtual ICollection<ShipmentHistory> ShipmentHistoryChangeUserIdentities { get; set; }
        public virtual ICollection<ShipmentHistory> ShipmentHistoryCreateUserIdentities { get; set; }
        public virtual ICollection<ShipmentStatusMapping> ShipmentStatusMappingChangeUserIdentities { get; set; }
        public virtual ICollection<ShipmentStatusMapping> ShipmentStatusMappingCreateUserIdentities { get; set; }
        public virtual ICollection<StatusLookup> StatusLookupChangeUserIdentities { get; set; }
        public virtual ICollection<StatusLookup> StatusLookupCreateUserIdentities { get; set; }
        public virtual ICollection<StoreUser> StoreUsers { get; set; }
        public virtual ICollection<Town> TownChangeUserIdentities { get; set; }
        public virtual ICollection<Town> TownCreateUserIdentities { get; set; }
        public virtual ICollection<TypeLookup> TypeLookupChangeUserIdentities { get; set; }
        public virtual ICollection<TypeLookup> TypeLookupCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentityAccount> UserIdentityAccountChangeUserIdentities { get; set; }
        public virtual ICollection<UserIdentityAccount> UserIdentityAccountCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentityAccount> UserIdentityAccountUserIdentities { get; set; }
        public virtual ICollection<UserIdentityClient> UserIdentityClientChangeUserIdentities { get; set; }
        public virtual ICollection<UserIdentityClient> UserIdentityClientCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentityClient> UserIdentityClientUserIdentities { get; set; }
        public virtual ICollection<UserIdentityLocation> UserIdentityLocationChangeUserIdentities { get; set; }
        public virtual ICollection<UserIdentityLocation> UserIdentityLocationCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentityLocation> UserIdentityLocationUserIdentities { get; set; }
        public virtual ICollection<UserIdentityOperationClaim> UserIdentityOperationClaimChangeUserIdentities { get; set; }
        public virtual ICollection<UserIdentityOperationClaim> UserIdentityOperationClaimCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentityOperationClaim> UserIdentityOperationClaimUserIdentities { get; set; }
        public virtual ICollection<UserIdentityOperationRole> UserIdentityOperationRoleChangeUserIdentities { get; set; }
        public virtual ICollection<UserIdentityOperationRole> UserIdentityOperationRoleCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentityOperationRole> UserIdentityOperationRoleUserIdentities { get; set; }
    }
}
