using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class SiteStat
    {
        public uint SsRowId { get; set; }
        public ulong? SsTotalEdits { get; set; }
        public ulong? SsGoodArticles { get; set; }
        public ulong? SsTotalPages { get; set; }
        public ulong? SsUsers { get; set; }
        public ulong? SsActiveUsers { get; set; }
        public ulong? SsImages { get; set; }
    }
}
