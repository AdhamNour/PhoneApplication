using PhoneApplication.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using System.Linq;
using PhoneApplication.Database;

namespace PhoneApplication.Services
{
    public static class ContactServices
    {
        static List<Contact> contacts { get; set; }
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

            var _context = new ApplicationDBContext();

            return _context.Contacts.ToList();
        }
        public static void addContact(Contact contact)
        {
            var _context = new ApplicationDBContext();
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }
        public static Contact GetContactById(string id)
        {
            var _context = new ApplicationDBContext();
            return _context.Contacts.Where(contact => contact.Id.Equals(id)).First() ;
        }

        public static void UpdateContact(Contact NewContact,string id)
        {
            var _context = new ApplicationDBContext();
            NewContact.Id = id;
            _context.Update(NewContact);
            _context.SaveChanges();

        }

        public static void DeleteContact (string id)
        {
            var _context = new ApplicationDBContext();
            var contact = _context.Contacts.Where(_contact => _contact.Id.Equals(id)).First();
            _context.Contacts.Remove(contact);
            _context.SaveChanges();
        }
    }
}
 