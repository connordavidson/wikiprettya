using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class WatchlistExpiry
    {
        public uint WeItem { get; set; }
        public byte[] WeExpiry { get; set; }
    }
}
