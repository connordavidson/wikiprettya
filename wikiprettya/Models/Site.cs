using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Site
    {
        public uint SiteId { get; set; }
        public byte[] SiteGlobalKey { get; set; }
        public byte[] SiteType { get; set; }
        public byte[] SiteGroup { get; set; }
        public byte[] SiteSource { get; set; }
        public byte[] SiteLanguage { get; set; }
        public byte[] SiteProtocol { get; set; }
        public string SiteDomain { get; set; }
        public byte[] SiteData { get; set; }
        public bool SiteForward { get; set; }
        public byte[] SiteConfig { get; set; }
    }
}
