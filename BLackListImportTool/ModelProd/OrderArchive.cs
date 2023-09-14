using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class OrderArchive
    {
        public long OrderId { get; set; }
        public string OrderNumber { get; set; } = null!;
        public long? ClientId { get; set; }
        public long? AccountId { get; set; }
        public long? TotalQuantity { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? VersionNumber { get; set; }
        public bool? SendSmsNotification { get; set; }
        public bool? SendEmailNotification { get; set; }
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
