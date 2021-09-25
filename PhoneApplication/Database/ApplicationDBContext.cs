using Microsoft.EntityFrameworkCore;
using PhoneApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneApplication.Database
{
    public class ApplicationDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL("server=localhost;user=root;database=phone_application;password=123456");
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
