﻿using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Page
    {
        public uint PageId { get; set; }
        public int PageNamespace { get; set; }
        public byte[] PageTitle { get; set; }
        public byte PageIsRedirect { get; set; }
        public byte PageIsNew { get; set; }
        public double PageRandom { get; set; }
        public byte[] PageTouched { get; set; }
        public byte[] PageLinksUpdated { get; set; }
        public uint PageLatest { get; set; }
        public uint PageLen { get; set; }
        public byte[] PageContentModel { get; set; }
        public byte[] PageLang { get; set; }
    }
}
