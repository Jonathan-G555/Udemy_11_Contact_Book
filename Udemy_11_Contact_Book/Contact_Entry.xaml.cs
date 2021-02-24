using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Udemy_11_Contact_Book.Models;


namespace Udemy_11_Contact_Book
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contact_Entry : ContentPage
    {
        public Contact_Entry()
        {
            InitializeComponent();
        }
        /*
        private void Add_Button_Clicked(object sender, EventArgs e)
        {
            List_C.Add(new Contacts("First_Entry", "Second_Entry", "Phone_Entry", "Email_Entry", true));
        }
    */
    }
}