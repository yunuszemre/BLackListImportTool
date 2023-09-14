using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class ShipmentDeliveryReceipt
    {
        public ShipmentDeliveryReceipt()
        {
            ShipmentDeliveryReceiptLines = new HashSet<ShipmentDeliveryReceiptLine>();
        }

        public long ShipmentDeliveryReceiptId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long CarrierId { get; set; }
        public long? DriverId { get; set; }
        public long? CarId { get; set; }
        public long? LocationId { get; set; }
        public long? RouteId { get; set; }
        public string ReceiptCode { get; set; } = null!;
        public string? StoreCode { get; set; }
        public string? StoreName { get; set; }
        public long ShipmentDeliveryReceiptStatusId { get; set; }
        public long ShipmentDeliveryReceiptTypeId { get; set; }
        public string? DeliveredSerialNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[]? RowVersion { get; set; }
        public bool IfTransferredToSecondary { get; set; }
        public byte[]? ReceiverSignature { get; set; }
        public byte[]? DelivererSignature { get; set; }
        public string? ReceiptFile { get; set; }
        public long? ShipmentDeliveryPositionId { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Car? Car { get; set; }
        public virtual Carrier Carrier { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual UserIdentity? Driver { get; set; }
        public virtual Route? Route { get; set; }
        public virtual ICollection<ShipmentDeliveryReceiptLine> ShipmentDeliveryReceiptLines { get; set; }
    }
}
