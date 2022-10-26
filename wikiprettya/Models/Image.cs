using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Image
    {
        public byte[] ImgName { get; set; }
        public uint ImgSize { get; set; }
        public int ImgWidth { get; set; }
        public int ImgHeight { get; set; }
        public byte[] ImgMetadata { get; set; }
        public int ImgBits { get; set; }
        public string ImgMediaType { get; set; }
        public string ImgMajorMime { get; set; }
        public byte[] ImgMinorMime { get; set; }
        public ulong ImgDescriptionId { get; set; }
        public ulong ImgActor { get; set; }
        public byte[] ImgTimestamp { get; set; }
        public byte[] ImgSha1 { get; set; }
    }
}
