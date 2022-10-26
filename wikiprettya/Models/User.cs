using System;
using System.Collections.Generic;

namespace wikiprettya.Models
{
    public partial class User
    {
        public uint UserId { get; set; }
        public byte[] UserName { get; set; }
        public byte[] UserRealName { get; set; }
        public byte[] UserPassword { get; set; }
        public byte[] UserNewpassword { get; set; }
        public byte[] UserNewpassTime { get; set; }
        public string UserEmail { get; set; }
        public byte[] UserTouched { get; set; }
        public byte[] UserToken { get; set; }
        public byte[] UserEmailAuthenticated { get; set; }
        public byte[] UserEmailToken { get; set; }
        public byte[] UserEmailTokenExpires { get; set; }
        public byte[] UserRegistration { get; set; }
        public uint? UserEditcount { get; set; }
        public byte[] UserPasswordExpires { get; set; }
    }
}
