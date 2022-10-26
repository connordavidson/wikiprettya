using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class ChangeTagDef
    {
        public uint CtdId { get; set; }
        public byte[] CtdName { get; set; }
        public bool CtdUserDefined { get; set; }
        public ulong CtdCount { get; set; }
    }
}
