using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class PageRestriction
    {
        public uint PrId { get; set; }
        public uint PrPage { get; set; }
        public byte[] PrType { get; set; }
        public byte[] PrLevel { get; set; }
        public sbyte PrCascade { get; set; }
        public byte[] PrExpiry { get; set; }
    }
}
