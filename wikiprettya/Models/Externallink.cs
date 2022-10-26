using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Externallink
    {
        public uint ElId { get; set; }
        public uint ElFrom { get; set; }
        public byte[] ElTo { get; set; }
        public byte[] ElIndex { get; set; }
        public byte[] ElIndex60 { get; set; }
        public byte[] ElToDomainIndex { get; set; }
        public byte[] ElToPath { get; set; }
    }
}
