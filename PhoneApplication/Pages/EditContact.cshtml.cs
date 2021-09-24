using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhoneApplication.Models;
using PhoneApplication.Services;

namespace PhoneApplication.Pages
{
    public class EditContactModel : PageModel
    {
        [BindProperty]
        public Contact targetContact { get; set; }
        public void OnGet()
        {
            Contact contact = ContactServices.GetContactById(RouteData.Values["handler"] as string);
            targetContact = contact;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ContactServices.UpdateContact(targetContact, RouteData.Values["handler"] as string);
            return RedirectToPage("Index");
        }
    }
}
