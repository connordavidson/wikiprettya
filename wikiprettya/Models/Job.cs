using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Job
    {
        public uint JobId { get; set; }
        public byte[] JobCmd { get; set; }
        public int JobNamespace { get; set; }
        public byte[] JobTitle { get; set; }
        public byte[] JobTimestamp { get; set; }
        public byte[] JobParams { get; set; }
        public uint JobRandom { get; set; }
        public uint JobAttempts { get; set; }
        public byte[] JobToken { get; set; }
        public byte[] JobTokenTimestamp { get; set; }
        public byte[] JobSha1 { get; set; }
    }
}
