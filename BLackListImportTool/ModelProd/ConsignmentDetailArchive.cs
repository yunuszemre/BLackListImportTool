﻿using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class ConsignmentDetailArchive
    {
        public long ConsignmentDetailId { get; set; }
        public long ConsignmentId { get; set; }
        public string? ProductCode { get; set; }
        public string? Barcode { get; set; }
        public string? ProductName { get; set; }
        public string? LineId { get; set; }
        public int? LineQuantity { get; set; }
        public decimal? ProductPrice { get; set; }
        public string? ProductTypeCode { get; set; }
        public decimal? ProductVolumetricWeight { get; set; }
        public decimal? ProductWeight { get; set; }
        public long? LocationId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public string? ProductAttr1 { get; set; }
        public string? ProductAttr2 { get; set; }
        public string? ProductAttr3 { get; set; }
        public string? ProductAttr4 { get; set; }
        public string? ProductAttr5 { get; set; }
        public DateTime? ArchiveDate { get; set; }
    }
}
