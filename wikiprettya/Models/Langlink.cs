using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Langlink
    {
        public uint LlFrom { get; set; }
        public byte[] LlLang { get; set; }
        public byte[] LlTitle { get; set; }
    }
}
