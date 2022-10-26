using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class Category
    {
        public uint CatId { get; set; }
        public byte[] CatTitle { get; set; }
        public int CatPages { get; set; }
        public int CatSubcats { get; set; }
        public int CatFiles { get; set; }
    }
}
