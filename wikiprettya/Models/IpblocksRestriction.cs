using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class IpblocksRestriction
    {
        public uint IrIpbId { get; set; }
        public sbyte IrType { get; set; }
        public uint IrValue { get; set; }
    }
}
