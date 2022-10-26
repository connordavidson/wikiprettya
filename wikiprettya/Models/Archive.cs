using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Archive
    {
        public uint ArId { get; set; }
        public int ArNamespace { get; set; }
        public byte[] ArTitle { get; set; }
        public ulong ArCommentId { get; set; }
        public ulong ArActor { get; set; }
        public byte[] ArTimestamp { get; set; }
        public sbyte ArMinorEdit { get; set; }
        public uint ArRevId { get; set; }
        public byte ArDeleted { get; set; }
        public uint? ArLen { get; set; }
        public uint? ArPageId { get; set; }
        public uint? ArParentId { get; set; }
        public byte[] ArSha1 { get; set; }
    }
}
