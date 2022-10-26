using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class UserGroup
    {
        public uint UgUser { get; set; }
        public byte[] UgGroup { get; set; }
        public byte[] UgExpiry { get; set; }
    }
}
