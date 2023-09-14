using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class AggregatedCounter
    {
        public string Key { get; set; } = null!;
        public long Value { get; set; }
        public DateTime? ExpireAt { get; set; }
        public bool IfTransferredToSecondary { get; set; }
    }
}
