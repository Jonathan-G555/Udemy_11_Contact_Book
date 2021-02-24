using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy_11_Contact_Book
{
    public class Contacts
    {
        public string First_Name { get; set; }
        public string Second_Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public bool Blocked { get; set; }

        public Contacts(string first_Name, string second_Name, string phone, string email, bool blocked)
        {
            First_Name = first_Name;
            Second_Name = second_Name;
            Phone = phone;
            Email = email;
            Blocked = blocked;
            Name = First_Name + " " + Second_Name;
        }
    }
}
