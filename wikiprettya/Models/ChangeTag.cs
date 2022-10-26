using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class ChangeTag
    {
        public uint CtId { get; set; }
        public uint? CtRcId { get; set; }
        public uint? CtLogId { get; set; }
        public uint? CtRevId { get; set; }
        public byte[] CtParams { get; set; }
        public uint CtTagId { get; set; }
    }
}
