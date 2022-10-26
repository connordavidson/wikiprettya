using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Interwiki
    {
        public string IwPrefix { get; set; }
        public byte[] IwUrl { get; set; }
        public byte[] IwApi { get; set; }
        public string IwWikiid { get; set; }
        public bool IwLocal { get; set; }
        public sbyte IwTrans { get; set; }
    }
}
