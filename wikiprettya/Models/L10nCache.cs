using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class L10nCache
    {
        public byte[] LcLang { get; set; }
        public string LcKey { get; set; }
        public byte[] LcValue { get; set; }
    }
}
