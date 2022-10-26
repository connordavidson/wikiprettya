using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Slot
    {
        public ulong SlotRevisionId { get; set; }
        public ushort SlotRoleId { get; set; }
        public ulong SlotContentId { get; set; }
        public ulong SlotOrigin { get; set; }
    }
}
