using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Filearchive
    {
        public uint FaId { get; set; }
        public byte[] FaName { get; set; }
        public byte[] FaArchiveName { get; set; }
        public byte[] FaStorageGroup { get; set; }
        public byte[] FaStorageKey { get; set; }
        public int? FaDeletedUser { get; set; }
        public byte[] FaDeletedTimestamp { get; set; }
        public ulong FaDeletedReasonId { get; set; }
        public uint? FaSize { get; set; }
        public int? FaWidth { get; set; }
        public int? FaHeight { get; set; }
        public byte[] FaMetadata { get; set; }
        public int? FaBits { get; set; }
        public string FaMediaType { get; set; }
        public string FaMajorMime { get; set; }
        public byte[] FaMinorMime { get; set; }
        public ulong FaDescriptionId { get; set; }
        public ulong FaActor { get; set; }
        public byte[] FaTimestamp { get; set; }
        public byte FaDeleted { get; set; }
        public byte[] FaSha1 { get; set; }
    }
}
