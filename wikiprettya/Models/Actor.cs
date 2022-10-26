using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Actor
    {
        public ulong ActorId { get; set; }
        public uint? ActorUser { get; set; }
        public byte[] ActorName { get; set; }
    }
}
