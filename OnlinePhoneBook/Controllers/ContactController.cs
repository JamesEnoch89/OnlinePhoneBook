using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlinePhoneBook.Controllers
{
    [RoutePrefix("api/Contact")]
    public class ContactController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Contact.CreateContact());
        }

    }

    #region Helpers

    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PreferredMethod { get; set; }

        public static List<Contact> CreateContact()
        {
            List<Contact> ContactList = new List<Contact>
            {
                new Contact {ContactID = 10248, Name = "Taiseer Joudeh", Address = "Amman", Email = "Amman@test.com", PreferredMethod = "Phone"},
                new Contact {ContactID = 10249, Name = "Ahmad Hasan", Address = "Dubai", Email = "Dubai@test.com", PreferredMethod = "Email"},
                new Contact {ContactID = 10250,Name = "Tamer Yaser", Address = "Jeddah", Email = "Jeddah@test.com", PreferredMethod = "Email"},
                new Contact {ContactID = 10251,Name = "Lina Majed", Address = "Abu Dhabi", Email = "Abu Dhabi@test.com", PreferredMethod = "Phone"},
                new Contact {ContactID = 10252,Name = "Yasmeen Rami", Address = "Kuwait", Email = "Kuwait@test.com", PreferredMethod = "Phone"}
            };

            return ContactList;
        }
    }

    #endregion
}
