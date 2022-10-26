using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class ModuleDep
    {
        public byte[] MdModule { get; set; }
        public byte[] MdSkin { get; set; }
        public byte[] MdDeps { get; set; }
    }
}
