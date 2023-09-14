using System;
using System.Collections.Generic;

namespace BLackListImportTool.TMS_Models
{
    public partial class LocationCarrierReturnConfiguration
    {
        public long LocationCarrierReturnConfigurationId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long LocationId { get; set; }
        public long? CarrierId { get; set; }
        public int? Priority { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? CustomerCode { get; set; }
        public string? ApiKey { get; set; }
        public bool? SendToCarrierIfRmaAvailable { get; set; }
        public bool? IsActive { get; set; }
        public bool? IfRmaCodeSend { get; set; }
        public string? RmaServiceUserName { get; set; }
        public string? RmaServicePassword { get; set; }
        public long? RmacodeUsageLimit { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public string? ReturnCodePrefix { get; set; }
        public long? ReturnCodeStartNumber { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual Location Location { get; set; } = null!;
    }
}
