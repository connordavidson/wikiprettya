using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Categorylink
    {
        public uint ClFrom { get; set; }
        public byte[] ClTo { get; set; }
        public byte[] ClSortkey { get; set; }
        public byte[] ClSortkeyPrefix { get; set; }
        public DateTime ClTimestamp { get; set; }
        public byte[] ClCollation { get; set; }
        public string ClType { get; set; }
    }
}
