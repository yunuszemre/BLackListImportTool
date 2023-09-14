﻿using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class ShipmentArchive
    {
        public long ShipmentId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long? ConsignmentId { get; set; }
        public long? LocationId { get; set; }
        public long? CarrierId { get; set; }
        public long? ReturnId { get; set; }
        public string? ShipmentKey { get; set; }
        public long? ShipmentStatusId { get; set; }
        public string? CarrierShipmentStatus { get; set; }
        public string? CarrierTrackingCode { get; set; }
        public bool? IsActive { get; set; }
        public long? BarcodeLabelFormatTypeId { get; set; }
        public DateTime? EstimatedDeliveryTime { get; set; }
        public string? CargoResponse1 { get; set; }
        public string? CargoResponse2 { get; set; }
        public decimal? ShipmentVolumetricWeight { get; set; }
        public decimal? CarrierVolumetricWeight { get; set; }
        public decimal? ShipmentWeightKg { get; set; }
        public decimal? CarrierWeightKg { get; set; }
        public string? DocumentNumber { get; set; }
        public string? DocumentId { get; set; }
        public decimal? CarrierGrossPrice { get; set; }
        public string? CarrierResultCode { get; set; }
        public string? CarrierResult { get; set; }
        public string? TrackingUrl { get; set; }
        public string? TrackingNumber { get; set; }
        public long? ShipmentTypeId { get; set; }
        public DateTime? CarrierKeyCreateTime { get; set; }
        public DateTime? CarrierInitialTime { get; set; }
        public DateTime? CarrierOnDeliveryTime { get; set; }
        public DateTime? CarrierDeliveredTime { get; set; }
        public DateTime? CarrierNotDeliveredTime { get; set; }
        public long? SystemStatusId { get; set; }
        public long? RetryCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public bool IfTransferredToSecondary { get; set; }
        public long? BarcodeLabelIntegrationTypeId { get; set; }
        public decimal? CalculatedPrice { get; set; }
        public decimal? CalculatedShippingCost { get; set; }
        public decimal? CalculatedShippingCustomerCost { get; set; }
        public bool? IsAppliedForDeliveryReceipt { get; set; }
        public long? ToLocationId { get; set; }
        public long? NextLocationId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public DateTime? ArchiveDate { get; set; }
    }
}
