using PBCTracker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBCTracker.Services
{
    public interface IUserRepository
    {
        IEnumerable<UserProfile> GetAllApproverProfiles();
        IEnumerable<UserProfile> GetAllProfiles();
        UserProfile GetUser(string username);
    }
}
