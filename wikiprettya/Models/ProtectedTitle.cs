using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class ProtectedTitle
    {
        public int PtNamespace { get; set; }
        public byte[] PtTitle { get; set; }
        public uint PtUser { get; set; }
        public ulong PtReasonId { get; set; }
        public byte[] PtTimestamp { get; set; }
        public byte[] PtExpiry { get; set; }
        public byte[] PtCreatePerm { get; set; }
    }
}
