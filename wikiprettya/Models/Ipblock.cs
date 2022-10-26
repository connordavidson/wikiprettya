using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Ipblock
    {
        public uint IpbId { get; set; }
        public byte[] IpbAddress { get; set; }
        public uint IpbUser { get; set; }
        public ulong IpbByActor { get; set; }
        public ulong IpbReasonId { get; set; }
        public byte[] IpbTimestamp { get; set; }
        public bool IpbAuto { get; set; }
        public bool IpbAnonOnly { get; set; }
        public bool? IpbCreateAccount { get; set; }
        public bool? IpbEnableAutoblock { get; set; }
        public byte[] IpbExpiry { get; set; }
        public byte[] IpbRangeStart { get; set; }
        public byte[] IpbRangeEnd { get; set; }
        public bool IpbDeleted { get; set; }
        public bool IpbBlockEmail { get; set; }
        public bool IpbAllowUsertalk { get; set; }
        public uint? IpbParentBlockId { get; set; }
        public bool? IpbSitewide { get; set; }
    }
}
