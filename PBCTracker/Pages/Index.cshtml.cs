using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PBCTracker.Models;
using PBCTracker.Services;

namespace PBCTracker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICaseRepository caseRepository;
        private readonly IUserRepository userRepository;

        public IndexModel(ICaseRepository caseRepository, IUserRepository userRepository)
        {
            this.caseRepository = caseRepository;
            

            // Mock the user logged in
            UserProfile = userRepository.GetUser("genesis\\eromito");

        }

        public IEnumerable<Case> Cases { get; set; }
      
        public UserProfile UserProfile { get; set; }
        public void OnGet()
        {
            Cases = caseRepository.GetUserCases(UserProfile);
        }
    }
}
