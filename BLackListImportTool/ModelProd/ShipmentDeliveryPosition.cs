using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class ShipmentDeliveryPosition
    {
        public long ShipmentDeliveryPositionId { get; set; }
        public long CarDriverId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[]? RowVersion { get; set; }
        public bool IfTransferredToSecondary { get; set; }
        public bool? IsOpen { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual CarDriver CarDriver { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
    }
}
