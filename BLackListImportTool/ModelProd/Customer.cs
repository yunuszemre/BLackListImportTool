﻿using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class Customer
    {
        public long CustomerId { get; set; }
        public string? CustomerCode { get; set; }
        public long? ConsignmentId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long LocationId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? MobilePhone { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public long? CustomerTypeId { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual UserIdentity? ChangeUserIdentity { get; set; }
        public virtual Client Client { get; set; } = null!;
        public virtual UserIdentity CreateUserIdentity { get; set; } = null!;
        public virtual Location Location { get; set; } = null!;
    }
}
