﻿using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class CarrierRouteMapping06022023Ydk
    {
        public long CarrierRouteMappingId { get; set; }
        public long CarrierId { get; set; }
        public long? CountryId { get; set; }
        public long? CityId { get; set; }
        public long? TownId { get; set; }
        public long? DistrictId { get; set; }
        public int? RoutingLevel { get; set; }
        public bool? IsMobileBranch { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
    }
}
