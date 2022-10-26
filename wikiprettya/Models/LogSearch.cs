using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class LogSearch
    {
        public byte[] LsField { get; set; }
        public string LsValue { get; set; }
        public uint LsLogId { get; set; }
    }
}
