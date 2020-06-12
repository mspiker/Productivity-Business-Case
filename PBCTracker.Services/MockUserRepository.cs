using PBCTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBCTracker.Services
{
    public class MockUserRepository : IUserRepository
    {
        private List<UserProfile> _users;

        public MockUserRepository()
        {
            _users = new List<UserProfile>() {
                new UserProfile() { DisplayName="Mark Spiker", Username="genesis\\mspiker", Role=UserRoles.Stakeholder },
                new UserProfile() { DisplayName="Ed Romito", Username="genesis\\eromito", Role=UserRoles.Approver },
                new UserProfile() { DisplayName="Carol Hutchins", Username="genesis\\chutchins", Role=UserRoles.Stakeholder },
                new UserProfile() { DisplayName="Mark Goodall", Username="genesis\\mgoodall", Role=UserRoles.Stakeholder },
                new UserProfile() { DisplayName="Mike Norman", Username="genesis\\mnorman", Role=UserRoles.Approver }
            };
        }
        public IEnumerable<UserProfile> GetAllApproverProfiles()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserProfile> GetAllProfiles()
        {
            return _users;
        }

        public UserProfile GetUser(string username)
        {
            return _users.FirstOrDefault(u => u.Username == username);
        }
    }
}
