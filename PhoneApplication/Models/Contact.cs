using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace PhoneApplication.Models
{
    public class Contact
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public Guid Id { get; }

        public Contact()
        {
            Id = Guid.NewGuid();
        }
    }
}
