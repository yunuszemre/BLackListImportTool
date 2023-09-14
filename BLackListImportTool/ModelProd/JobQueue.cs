using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class JobQueue
    {
        public long Id { get; set; }
        public long JobId { get; set; }
        public string Queue { get; set; } = null!;
        public DateTime? FetchedAt { get; set; }
        public bool IfTransferredToSecondary { get; set; }
    }
}
