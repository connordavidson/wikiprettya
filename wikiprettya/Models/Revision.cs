using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Revision
    {
        public uint RevId { get; set; }
        public uint RevPage { get; set; }
        public ulong RevCommentId { get; set; }
        public ulong RevActor { get; set; }
        public byte[] RevTimestamp { get; set; }
        public byte RevMinorEdit { get; set; }
        public byte RevDeleted { get; set; }
        public uint? RevLen { get; set; }
        public uint? RevParentId { get; set; }
        public byte[] RevSha1 { get; set; }
    }
}
