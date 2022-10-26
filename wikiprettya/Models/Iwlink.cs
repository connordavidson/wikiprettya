using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Iwlink
    {
        public uint IwlFrom { get; set; }
        public byte[] IwlPrefix { get; set; }
        public byte[] IwlTitle { get; set; }
    }
}
