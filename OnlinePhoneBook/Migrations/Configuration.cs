namespace OnlinePhoneBook.Migrations
{
    using OnlinePhoneBook.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlinePhoneBook.Context.AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OnlinePhoneBook.Context.AuthContext";
        }

        protected override void Seed(OnlinePhoneBook.Context.AuthContext context)
        {
            var contacts = new List<Contact>
            {
                new Contact {ContactID = 10248, Name = "Taiseer Joudeh", Address = "Amman", Email = "Amman@test.com", PhoneNumber = "5555555555", PreferredMethod = "Phone"},
                new Contact {ContactID = 10249, Name = "Ahmad Hasan", Address = "Dubai", Email = "Dubai@test.com", PhoneNumber = "6666666666", PreferredMethod = "Email"},
                new Contact {ContactID = 10250,Name = "Tamer Yaser", Address = "Jeddah", Email = "Jeddah@test.com", PhoneNumber = "7777777777", PreferredMethod = "Email"},
                new Contact {ContactID = 10251,Name = "Lina Majed", Address = "Abu Dhabi", Email = "Abu Dhabi@test.com", PhoneNumber = "88888888", PreferredMethod = "Phone"},
                new Contact {ContactID = 10252,Name = "Yasmeen Rami", Address = "Kuwait", Email = "Kuwait@test.com", PhoneNumber = "9999999999", PreferredMethod = "Phone"}
            };

            contacts.ForEach(contact =>
            {
                context.ContactList.AddOrUpdate(a => a.Name, contact);
            });

            context.SaveChanges();

        }
        }
    }


