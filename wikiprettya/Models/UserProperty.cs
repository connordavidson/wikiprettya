using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class UserProperty
    {
        public uint UpUser { get; set; }
        public byte[] UpProperty { get; set; }
        public byte[] UpValue { get; set; }
    }
}
