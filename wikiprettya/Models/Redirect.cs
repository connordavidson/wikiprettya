using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Redirect
    {
        public uint RdFrom { get; set; }
        public int RdNamespace { get; set; }
        public byte[] RdTitle { get; set; }
        public string RdInterwiki { get; set; }
        public byte[] RdFragment { get; set; }
    }
}
