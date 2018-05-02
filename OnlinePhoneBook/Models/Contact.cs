using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlinePhoneBook.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PreferredMethod { get; set; }

       
    }
}