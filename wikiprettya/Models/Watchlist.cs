using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Watchlist
    {
        public uint WlId { get; set; }
        public uint WlUser { get; set; }
        public int WlNamespace { get; set; }
        public byte[] WlTitle { get; set; }
        public byte[] WlNotificationtimestamp { get; set; }
    }
}
