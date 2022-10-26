using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Recentchange
    {
        public uint RcId { get; set; }
        public byte[] RcTimestamp { get; set; }
        public ulong RcActor { get; set; }
        public int RcNamespace { get; set; }
        public byte[] RcTitle { get; set; }
        public ulong RcCommentId { get; set; }
        public byte RcMinor { get; set; }
        public byte RcBot { get; set; }
        public byte RcNew { get; set; }
        public uint RcCurId { get; set; }
        public uint RcThisOldid { get; set; }
        public uint RcLastOldid { get; set; }
        public byte RcType { get; set; }
        public byte[] RcSource { get; set; }
        public byte RcPatrolled { get; set; }
        public byte[] RcIp { get; set; }
        public int? RcOldLen { get; set; }
        public int? RcNewLen { get; set; }
        public byte RcDeleted { get; set; }
        public uint RcLogid { get; set; }
        public byte[] RcLogType { get; set; }
        public byte[] RcLogAction { get; set; }
        public byte[] RcParams { get; set; }
    }
}
