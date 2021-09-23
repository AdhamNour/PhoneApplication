using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhoneApplication.Models;

namespace PhoneApplication.Services
{
    public static class ContactServices
    {
        static List<Contact> contacts { get; }
        static ContactServices()
        {
            contacts = new List<Contact>
            {
                new Contact
                {
                    Name = "Adham",
                    PhoneNumber="01001516725"
                }, 
                new Contact
                {
                    Name = "Khaled",
                    PhoneNumber="01552423"
                }, 
                new Contact
                {
                    Name = "Hussing",
                    PhoneNumber="01442255330"
                },

            };
        }
        public static List<Contact> GetAll() => contacts;

    }
}
