using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class ShipmentHistoryArchive
    {
        public long ShipmentHistoryId { get; set; }
        public long? ShipmentId { get; set; }
        public long? StatusId { get; set; }
        public long? StatusDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public DateTime? ArchiveDate { get; set; }
    }
}
