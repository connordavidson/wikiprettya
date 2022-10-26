using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Oldimage
    {
        public byte[] OiName { get; set; }
        public byte[] OiArchiveName { get; set; }
        public uint OiSize { get; set; }
        public int OiWidth { get; set; }
        public int OiHeight { get; set; }
        public int OiBits { get; set; }
        public ulong OiDescriptionId { get; set; }
        public ulong OiActor { get; set; }
        public byte[] OiTimestamp { get; set; }
        public byte[] OiMetadata { get; set; }
        public string OiMediaType { get; set; }
        public string OiMajorMime { get; set; }
        public byte[] OiMinorMime { get; set; }
        public byte OiDeleted { get; set; }
        public byte[] OiSha1 { get; set; }
    }
}
