using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class StoreUser
    {
        public long StoreUserId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long StoreLocationId { get; set; }
        public long UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[]? RowVersion { get; set; }
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual Location StoreLocation { get; set; } = null!;
        public virtual UserIdentity User { get; set; } = null!;
    }
}
