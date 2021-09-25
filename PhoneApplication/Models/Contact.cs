using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneApplication.Models
{
    public class Contact
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        [Key]
        public string Id { get; set; }

        public Contact()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
