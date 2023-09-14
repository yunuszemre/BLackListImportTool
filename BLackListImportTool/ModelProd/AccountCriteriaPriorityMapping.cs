using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class AccountCriteriaPriorityMapping
    {
        public long AccountCriteriaPriorityMappingId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long CriteriaTypeId { get; set; }
        public long Priority { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual UserIdentity? ChangeUserIdentity { get; set; }
        public virtual Client Client { get; set; } = null!;
        public virtual UserIdentity CreateUserIdentity { get; set; } = null!;
        public virtual TypeLookup CriteriaType { get; set; } = null!;
    }
}
