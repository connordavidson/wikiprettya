using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class IpChange
    {
        public uint IpcRevId { get; set; }
        public byte[] IpcRevTimestamp { get; set; }
        public byte[] IpcHex { get; set; }
    }
}
