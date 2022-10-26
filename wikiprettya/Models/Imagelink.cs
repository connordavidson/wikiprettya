using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Imagelink
    {
        public uint IlFrom { get; set; }
        public byte[] IlTo { get; set; }
        public int IlFromNamespace { get; set; }
    }
}
