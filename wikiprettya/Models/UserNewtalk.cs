using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class UserNewtalk
    {
        public uint UserId { get; set; }
        public byte[] UserIp { get; set; }
        public byte[] UserLastTimestamp { get; set; }
    }
}
