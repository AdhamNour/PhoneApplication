using PhoneApplication.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using System.Linq;

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
        public static List<Contact> GetAll()
        {

            contacts.ForEach(contact => Debug.WriteLine(contact.Id.ToString()));
            return contacts;
        }
        public static void addContact(Contact contact)
        {
            contacts.Add(contact);
            Debug.WriteLine("Add Contact Function", "Contact Added Successfully");
        }
        public static Contact GetContactById(string id)
        {
            Guid targetGuid = Guid.Parse(id);
            Contact contact =contacts.First(contact => contact.Id.Equals(targetGuid));
            return contact;
        }

        public static void UpdateContact(Contact NewContact,string id)
        {

            contacts.ForEach(contact => Debug.WriteLine(contact.Id.ToString()));

            int targetIndex = contacts.FindIndex(contact => contact.Id.Equals(id));
            contacts[targetIndex].Name = NewContact.Name;
            contacts[targetIndex].PhoneNumber = NewContact.PhoneNumber;
        }


    }
}
