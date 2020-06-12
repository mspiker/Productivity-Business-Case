using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PBCTracker.Models;
using PBCTracker.Services;

namespace PBCTracker.Pages
{
    public class EditModel : PageModel
    {
        private readonly ICaseRepository caseRepository;

        public EditModel(ICaseRepository caseRepository)
        {
            this.caseRepository = caseRepository;
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
            var names = new List<string>() { "Mark Spiker (genesis\\mspiker)", "Another Spiker (genesis\\aspiker)" };
            return new JsonResult(names);
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