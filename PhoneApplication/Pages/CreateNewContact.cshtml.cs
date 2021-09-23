using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhoneApplication.Models;
using PhoneApplication.Services;
using System.Diagnostics;


namespace PhoneApplication.Pages
{

    public class CreateNewContentModel : PageModel
    {
        [BindProperty]
        public Contact NewContact { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ContactServices.addContact(NewContact);
            return RedirectToPage("Index");
        }
    }
}
