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

        public IndexModel(ICaseRepository caseRepository)
        {
            this.caseRepository = caseRepository;
        }

        public IEnumerable<Case> Cases { get; set; }
        public void OnGet()
        {
            Cases = caseRepository.GetUserCases("genesis\\eromito");
        }
    }
}
