using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Linktarget
    {
        public ulong LtId { get; set; }
        public int LtNamespace { get; set; }
        public byte[] LtTitle { get; set; }
    }
}
