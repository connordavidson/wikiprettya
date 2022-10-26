using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Objectcache
    {
        public byte[] Keyname { get; set; }
        public byte[] Value { get; set; }
        public byte[] Exptime { get; set; }
        public string Modtoken { get; set; }
        public uint? Flags { get; set; }
    }
}
