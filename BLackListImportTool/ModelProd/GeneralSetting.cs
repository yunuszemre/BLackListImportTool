using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class GeneralSetting
    {
        public long GeneralSettingId { get; set; }
        public long AccountId { get; set; }
        public long ClientId { get; set; }
        public string? Name { get; set; }
        public string Value { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
    }
}
