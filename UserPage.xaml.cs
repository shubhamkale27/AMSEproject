using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace prototype
{
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();
        }

        async void Save_Clicked(object sender, System.EventArgs e)
        {
            var personItem = (User)BindingContext;
            await App.Database.SaveUserAsync(personItem);
            await Navigation.PopAsync();
        }

        async void Cancel_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
