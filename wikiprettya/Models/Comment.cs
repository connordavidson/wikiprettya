using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Comment
    {
        public ulong CommentId { get; set; }
        public int CommentHash { get; set; }
        public byte[] CommentText { get; set; }
        public byte[] CommentData { get; set; }
    }
}
