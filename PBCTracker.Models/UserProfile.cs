using System;
using System.Collections.Generic;
using System.Text;

namespace PBCTracker.Models
{
    public class UserProfile
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public UserRoles Role { get; set; }
    }
}
