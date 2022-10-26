using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class PageProp
    {
        public uint PpPage { get; set; }
        public byte[] PpPropname { get; set; }
        public byte[] PpValue { get; set; }
        public float? PpSortkey { get; set; }
    }
}
