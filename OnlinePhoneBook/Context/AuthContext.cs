using System;
using System.Collections.Generic;
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
    }
}