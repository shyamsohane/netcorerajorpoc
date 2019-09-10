using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication5.Pages
{
    public class UpdateMyPlanModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty]
        public CustomerDetails custDetails { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/UpdateMyPlanModel");
        }
    }

    public class CustomerDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}