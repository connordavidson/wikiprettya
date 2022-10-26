using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Templatelink
    {
        public uint TlFrom { get; set; }
        public ulong TlTargetId { get; set; }
        public int TlFromNamespace { get; set; }
    }
}
