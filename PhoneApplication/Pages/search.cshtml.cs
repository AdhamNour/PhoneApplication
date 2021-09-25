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
    public class searchModel : PageModel
    {
        public List<Contact> contacts { get; set; }
        public void OnGet()
        {
            contacts = ContactServices.FilterByName(RouteData.Values["searchTarget"] as string);
        }
    }
}
