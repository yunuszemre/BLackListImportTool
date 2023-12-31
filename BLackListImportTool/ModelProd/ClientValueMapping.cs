﻿using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class ClientValueMapping
    {
        public long ClientValueMappingId { get; set; }
        public long ClientId { get; set; }
        public string? ClientCountryCode { get; set; }
        public string? ClientCityCode { get; set; }
        public string? ClientTownCode { get; set; }
        public string? ClientDistrictCode { get; set; }
        public string? ClientZipCode { get; set; }
        public long? CountryId { get; set; }
        public long? CityId { get; set; }
        public long? TownId { get; set; }
        public long? DistrictId { get; set; }
        public string? ZipCode { get; set; }
        public bool? IsMatched { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual UserIdentity? ChangeUserIdentity { get; set; }
        public virtual City? City { get; set; }
        public virtual Client Client { get; set; } = null!;
        public virtual Country? Country { get; set; }
        public virtual UserIdentity CreateUserIdentity { get; set; } = null!;
        public virtual District? District { get; set; }
        public virtual Town? Town { get; set; }
    }
}
