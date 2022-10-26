using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Text
    {
        public uint OldId { get; set; }
        public byte[] OldText { get; set; }
        public byte[] OldFlags { get; set; }
    }
}
