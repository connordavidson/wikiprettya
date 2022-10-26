using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class BotPassword
    {
        public uint BpUser { get; set; }
        public byte[] BpAppId { get; set; }
        public byte[] BpPassword { get; set; }
        public byte[] BpToken { get; set; }
        public byte[] BpRestrictions { get; set; }
        public byte[] BpGrants { get; set; }
    }
}
