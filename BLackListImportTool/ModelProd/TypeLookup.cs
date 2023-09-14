using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class TypeLookup
    {
        public TypeLookup()
        {
            AccountCarrierPlannedShipmentConfigurationDeliverySlotTypes = new HashSet<AccountCarrierPlannedShipmentConfiguration>();
            AccountCarrierPlannedShipmentConfigurationDeliveryTypes = new HashSet<AccountCarrierPlannedShipmentConfiguration>();
            AccountCriteriaPriorityMappings = new HashSet<AccountCriteriaPriorityMapping>();
            AccountDecisionRules = new HashSet<AccountDecisionRule>();
            AccountLocationWorkingSchedules = new HashSet<AccountLocationWorkingSchedule>();
            AccountServiceTypeRuleDeliverySlotTypes = new HashSet<AccountServiceTypeRule>();
            AccountServiceTypeRuleDeliveryTypes = new HashSet<AccountServiceTypeRule>();
            AccountServiceTypeRulePaymentTypes = new HashSet<AccountServiceTypeRule>();
            Addresses = new HashSet<Address>();
            CarrierDeliveryTypes = new HashSet<CarrierDeliveryType>();
            CarrierDistanceBetweenCityGroupCityGroupTypes = new HashSet<CarrierDistanceBetweenCityGroup>();
            CarrierDistanceBetweenCityGroupDistanceTypes = new HashSet<CarrierDistanceBetweenCityGroup>();
            CarrierRouteMappingMobileBranches = new HashSet<CarrierRouteMappingMobileBranch>();
            Cars = new HashSet<Car>();
            DocumentTemplates = new HashSet<DocumentTemplate>();
            LocationCarrierConfigurations = new HashSet<LocationCarrierConfiguration>();
            Locations = new HashSet<Location>();
            PlannedShipmentWorkingScheduleDeliverySlotTypes = new HashSet<PlannedShipmentWorkingSchedule>();
            PlannedShipmentWorkingScheduleDeliveryTypes = new HashSet<PlannedShipmentWorkingSchedule>();
            ReportHistories = new HashSet<ReportHistory>();
            ReportScriptParameterParameterDataTypes = new HashSet<ReportScriptParameter>();
            ReportScriptParameterParameterNameTypes = new HashSet<ReportScriptParameter>();
            WebHookSubscriptions = new HashSet<WebHookSubscription>();
        }

        public long TypeLookupId { get; set; }
        public string Code { get; set; } = null!;
        public long ProcessGroupId { get; set; }
        public string Description { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual UserIdentity? ChangeUserIdentity { get; set; }
        public virtual UserIdentity CreateUserIdentity { get; set; } = null!;
        public virtual ProcessGroup ProcessGroup { get; set; } = null!;
        public virtual ICollection<AccountCarrierPlannedShipmentConfiguration> AccountCarrierPlannedShipmentConfigurationDeliverySlotTypes { get; set; }
        public virtual ICollection<AccountCarrierPlannedShipmentConfiguration> AccountCarrierPlannedShipmentConfigurationDeliveryTypes { get; set; }
        public virtual ICollection<AccountCriteriaPriorityMapping> AccountCriteriaPriorityMappings { get; set; }
        public virtual ICollection<AccountDecisionRule> AccountDecisionRules { get; set; }
        public virtual ICollection<AccountLocationWorkingSchedule> AccountLocationWorkingSchedules { get; set; }
        public virtual ICollection<AccountServiceTypeRule> AccountServiceTypeRuleDeliverySlotTypes { get; set; }
        public virtual ICollection<AccountServiceTypeRule> AccountServiceTypeRuleDeliveryTypes { get; set; }
        public virtual ICollection<AccountServiceTypeRule> AccountServiceTypeRulePaymentTypes { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<CarrierDeliveryType> CarrierDeliveryTypes { get; set; }
        public virtual ICollection<CarrierDistanceBetweenCityGroup> CarrierDistanceBetweenCityGroupCityGroupTypes { get; set; }
        public virtual ICollection<CarrierDistanceBetweenCityGroup> CarrierDistanceBetweenCityGroupDistanceTypes { get; set; }
        public virtual ICollection<CarrierRouteMappingMobileBranch> CarrierRouteMappingMobileBranches { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<DocumentTemplate> DocumentTemplates { get; set; }
        public virtual ICollection<LocationCarrierConfiguration> LocationCarrierConfigurations { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<PlannedShipmentWorkingSchedule> PlannedShipmentWorkingScheduleDeliverySlotTypes { get; set; }
        public virtual ICollection<PlannedShipmentWorkingSchedule> PlannedShipmentWorkingScheduleDeliveryTypes { get; set; }
        public virtual ICollection<ReportHistory> ReportHistories { get; set; }
        public virtual ICollection<ReportScriptParameter> ReportScriptParameterParameterDataTypes { get; set; }
        public virtual ICollection<ReportScriptParameter> ReportScriptParameterParameterNameTypes { get; set; }
        public virtual ICollection<WebHookSubscription> WebHookSubscriptions { get; set; }
    }
}
