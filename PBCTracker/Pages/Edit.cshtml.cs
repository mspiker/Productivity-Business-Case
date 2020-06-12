using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Server.IIS.Core;
using PBCTracker.Models;
using PBCTracker.Services;

namespace PBCTracker.Pages
{
    public class EditModel : PageModel
    {
        private readonly ICaseRepository caseRepository;
        private readonly IUserRepository userRepository;

        public EditModel(ICaseRepository caseRepository, IUserRepository userRepository)
        {
            this.caseRepository = caseRepository;
            this.userRepository = userRepository;
        }
        [BindProperty]
        public Case Case { get; set; }

        public IActionResult OnGet(int? id)
        {
            Case = caseRepository.GetCase(id.Value);
            return Page();
        }

        public IActionResult OnGetSearch(string term)
        {
            var results = userRepository.GetAllProfiles()
                .Where(u => u.DisplayName.ToLower().Contains(term.ToLower()) || u.Username.ToLower().Contains(term.ToLower()))
                .Select(u => new { label = u.DisplayName, value = u.Username }).ToList();
            return new JsonResult(results);
        }
        public IActionResult OnGetAddStakeholder(string data)
        {
            // find the record
            // validate the record
            // get the username
            if (data == null || data.StartsWith("!"))
            {
                return new JsonResult("!error");
            }
            else
            {
                return new JsonResult((data).ToString());
            }
        }
    }
}