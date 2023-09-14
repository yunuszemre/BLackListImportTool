using System;
using System.Collections.Generic;

namespace BLackListImportTool.TMS_Models
{
    public partial class ReturnConfiguration
    {
        public long ReturnConfigurationId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public string? ReturnPageClientLogoUrl { get; set; }
        public long? DefaultLocationId { get; set; }
        public long? DefaultCarrierId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual Carrier? DefaultCarrier { get; set; }
    }
}
