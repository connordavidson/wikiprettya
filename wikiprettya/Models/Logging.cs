using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Logging
    {
        public uint LogId { get; set; }
        public byte[] LogType { get; set; }
        public byte[] LogAction { get; set; }
        public byte[] LogTimestamp { get; set; }
        public ulong LogActor { get; set; }
        public int LogNamespace { get; set; }
        public byte[] LogTitle { get; set; }
        public uint? LogPage { get; set; }
        public ulong LogCommentId { get; set; }
        public byte[] LogParams { get; set; }
        public byte LogDeleted { get; set; }
    }
}
