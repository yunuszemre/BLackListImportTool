using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class JobParameter
    {
        public long JobId { get; set; }
        public string Name { get; set; } = null!;
        public string? Value { get; set; }
        public bool IfTransferredToSecondary { get; set; }

        public virtual Job Job { get; set; } = null!;
    }
}
