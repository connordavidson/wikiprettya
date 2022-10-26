using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Pagelink
    {
        public uint PlFrom { get; set; }
        public int PlNamespace { get; set; }
        public byte[] PlTitle { get; set; }
        public int PlFromNamespace { get; set; }
    }
}
