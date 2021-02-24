using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Udemy_11_Contact_Book.Models;


namespace Udemy_11_Contact_Book
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Contacts> List_C = new ObservableCollection<Contacts>{
            new Contacts("Jonathan", "García", "97729650", null, false),
            new Contacts("Sindy", "García", "22213512", null, false)
            };
        
        public MainPage()
        {
            InitializeComponent();
            List_contacts.ItemsSource = List_C;
        }


        async private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Contact_profile());
            await Navigation.PushAsync(new Contact_Entry());
        }

        async public void List_contacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            Contacts contact = e.SelectedItem as Contacts;
            //await Navigation.PushAsync(new Contact_profile() { BindingContext = contact });
            await Navigation.PushAsync(new Contact_Entry() { BindingContext = contact });
            List_contacts.SelectedItem = null;
        }

        private void Delete_Item_Clicked(object sender, EventArgs e)
        {
            var menu_item = sender as MenuItem;
            var contact = menu_item.CommandParameter as Contacts;
            List_C.Remove(contact);
        }

        
        /*
         * private void Add_Button_Clicked(object sender, EventArgs e)
        {
            List_C.Add(new Contacts("First_Entry", "Second_Entry", "Phone_Entry", "Email_Entry", true));
        }
        */
    }
}
