﻿using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class ShipmentDetailLineArchive
    {
        public long ShipmentDetailLineId { get; set; }
        public long ShipmentDetailId { get; set; }
        public string? LineId { get; set; }
        public int? LineQuantity { get; set; }
        public string? CustomerSpecificCode { get; set; }
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
