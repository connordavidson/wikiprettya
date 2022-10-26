using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Querycache
    {
        public byte[] QcType { get; set; }
        public uint QcValue { get; set; }
        public int QcNamespace { get; set; }
        public byte[] QcTitle { get; set; }
    }
}
