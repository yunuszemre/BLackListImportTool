using System;
using System.Collections.Generic;

namespace BLackListImportTool.ModelProd
{
    public partial class ArchiveableDatum
    {
        public long? OrderCount { get; set; }
        public long? ConsignmentCount { get; set; }
        public long? ShipmentCount { get; set; }
        public long? CustomerCount { get; set; }
        public long? AddressCount { get; set; }
    }
}
