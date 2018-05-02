using Microsoft.AspNet.Identity.EntityFramework;
using OnlinePhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlinePhoneBook.Context
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }

        public DbSet<Contact> ContactList { get; set; }
    }
}