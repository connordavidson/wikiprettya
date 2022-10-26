using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class SiteIdentifier
    {
        public byte[] SiType { get; set; }
        public byte[] SiKey { get; set; }
        public uint SiSite { get; set; }
    }
}
