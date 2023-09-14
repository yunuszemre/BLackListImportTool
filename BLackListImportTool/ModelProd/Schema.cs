using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class Schema
    {
        public int Version { get; set; }
        public bool IfTransferredToSecondary { get; set; }
    }
}
