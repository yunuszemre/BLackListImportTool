using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class ConsignmentArchive
    {
        public long ConsignmentId { get; set; }
        public string ConsignmentNumber { get; set; } = null!;
        public long? OrderId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long LocationId { get; set; }
        public long ConsignmentStatusId { get; set; }
        public long? SalesChannelId { get; set; }
        public string? SalesChannelTrackingNumber { get; set; }
        public long? TotalQuantity { get; set; }
        public decimal? TotalPrice { get; set; }
        public long? CarrierId { get; set; }
        public long? PaymentTypeId { get; set; }
        public decimal? CurrentPrice { get; set; }
        public int? VersionNumber { get; set; }
        public bool? IsShipmentCreated { get; set; }
        public decimal? VolumetricWeight { get; set; }
        public decimal? Weight { get; set; }
        public long? DeliveryTypeId { get; set; }
        public long? DeliverySlotTypeId { get; set; }
        public bool? IsCarrierChangable { get; set; }
        public DateTime? EstimatedPackagingCompletionDate { get; set; }
        public DateTime? ExpectedPackagingCompletionDueDate { get; set; }
        public bool? IsActive { get; set; }
        public long? ManuallyCreateReasonTypeId { get; set; }
        public string? ManuallyCreateNote { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public long? RouteId { get; set; }
        public bool? IsStatusTrackManuel { get; set; }
        public long? VendorId { get; set; }
        public DateTime? ArchiveDate { get; set; }
    }
}
