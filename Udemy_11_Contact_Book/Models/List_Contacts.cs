using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Udemy_11_Contact_Book.Models
{
    public class List_Contacts: ObservableCollection<Contacts>
    {

        public List<Contacts> List_Cont = new List<Contacts>{
            new Contacts("Jonathan", "García", "97729650", null, false),
            new Contacts("Sindy", "García", "22213512", null, false)
        };
        
        public List<Contacts> Get_list()
        {
            return List_Cont;
        }

        public void Add_Element(Contacts contact)
        {
            List_Cont.Add(contact);
        }
        
        public void Delete_Element(Contacts contact)
        {
            List_Cont.Remove(contact);
        }
    }
}
