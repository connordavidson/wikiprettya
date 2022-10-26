using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Uploadstash
    {
        public uint UsId { get; set; }
        public uint UsUser { get; set; }
        public string UsKey { get; set; }
        public string UsOrigPath { get; set; }
        public string UsPath { get; set; }
        public string UsSourceType { get; set; }
        public byte[] UsTimestamp { get; set; }
        public string UsStatus { get; set; }
        public uint? UsChunkInx { get; set; }
        public byte[] UsProps { get; set; }
        public uint UsSize { get; set; }
        public string UsSha1 { get; set; }
        public string UsMime { get; set; }
        public string UsMediaType { get; set; }
        public uint? UsImageWidth { get; set; }
        public uint? UsImageHeight { get; set; }
        public ushort? UsImageBits { get; set; }
    }
}
