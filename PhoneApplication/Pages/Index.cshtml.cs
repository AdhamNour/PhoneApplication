using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using PhoneApplication.Services;
using PhoneApplication.Models;

namespace PhoneApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Contact> contacts;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            contacts = ContactServices.GetAll();
            Debug.WriteLine(contacts);
        }
        public  IActionResult OnPostDeleteAsync(string id)
        {
            //            var contact = await _db.Customers.FindAsync(id);
            ContactServices.DeleteContact(id);

            return RedirectToPage();
        }
    }
}
