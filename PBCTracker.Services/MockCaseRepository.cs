using PBCTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBCTracker.Services
{
    public class MockCaseRepository : ICaseRepository
    {
        private List<Case> _caseList;
        public MockCaseRepository()
        {
            _caseList = new List<Case>()
            { 
                new Case()
                {
                    id = 1,
                    Title = "2 New Business Intelligence Developers",
                    Department = "Information Technology",
                    CostCenter = "7370",
                    RequestType = RequestTypes.New,
                    SubmittedDate = DateTime.Now.AddDays(-24),
                    Username = "genesis\\mspiker",
                    Status = StatusCodes.Draft,
                    Situation = "Situation",
                    Background = "Background",
                    Assessment = "Assessment",
                    Recommendation = "Recommendations",
                    Approvers = { "genesis\\eromito" }
                },

                new Case() {
                    id = 2,
                    Title = "Replace Imaging Resource due to Retirement",
                    Department = "Information Technology",
                    CostCenter = "7375",
                    RequestType = RequestTypes.New,
                    SubmittedDate = DateTime.Now.AddDays(-24),
                    Username = "genesis\\sburtnett",
                    Status = StatusCodes.PendingReview,
                    Situation = "Situation",
                    Background = "Background",
                    Assessment = "Assessment",
                    Recommendation = "Recommendations",
                    Approvers = { "genesis\\eromito" }
                },

                new Case() {
                    id = 3,
                    Title = "Case submitted by Dept Assistant",
                    Department = "Information Technology",
                    CostCenter = "7375",
                    RequestType = RequestTypes.Restructure,
                    SubmittedDate = DateTime.Now.AddDays(-4),
                    Username = "genesis\\sduffy",
                    Status = StatusCodes.Approved,
                    Situation = "Situation",
                    Background = "Background",
                    Assessment = "Assessment",
                    Recommendation = "Recommendations",
                    Approvers = { "genesis\\eromito", "genesis\\mnorman" },
                    Stakeholders = { "genesis\\mgoodall" }
                },

                new Case() {
                    id = 4,
                    Title = "This case is in draft stus to get a new Business Intelligence Analyst",
                    Department = "Quality",
                    CostCenter = "7375",
                    RequestType = RequestTypes.Restructure,
                    SubmittedDate = DateTime.Now.AddDays(-4),
                    Username = "genesis\\chutchins",
                    Status = StatusCodes.Draft,
                    Situation = "Situation",
                    Background = "Background",
                    Assessment = "Assessment",
                    Recommendation = "Recommendations",
                    Approvers = { "genesis\\eromito", "genesis\\mnorman" },
                    Stakeholders = { "genesis\\mspiker", "genesis\\eromito" }
                }
            };

    }
    public IEnumerable<Case> GetAllCases()
        {
            throw new NotImplementedException();
        }

        public Case GetCase(int id)
        {
            return _caseList.FirstOrDefault(c => c.id == id);
        }

        public IEnumerable<Case> GetUserCases(UserProfile UserProfile)
        {
            // Account for the requests > 90 days old
            return _caseList.Where(c => 
                (c.Username == UserProfile.Username) | 
                (c.Stakeholders.Contains(UserProfile.Username)) |
                ( c.Approvers.Contains(UserProfile.Username) && c.Status != StatusCodes.Draft));
        }
    }
}
