using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class ShipmentDocument
    {
        public long ShipmentDocumentId { get; set; }
        public long? ShipmentId { get; set; }
        public long? ShipmentDetailId { get; set; }
        public string? Text { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public string? BarcodeValue { get; set; }

        public virtual UserIdentity? ChangeUserIdentity { get; set; }
        public virtual UserIdentity CreateUserIdentity { get; set; } = null!;
    }
}
