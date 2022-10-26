using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Content
    {
        public ulong ContentId { get; set; }
        public uint ContentSize { get; set; }
        public byte[] ContentSha1 { get; set; }
        public ushort ContentModel { get; set; }
        public byte[] ContentAddress { get; set; }
    }
}
