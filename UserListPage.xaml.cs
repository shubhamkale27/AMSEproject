using System;

using System.Collections.Generic;
using Xamarin.Forms;

namespace prototype
{
    public partial class UserListPage : ContentPage
    {
        public UserListPage()
        {
            InitializeComponent();
            this.Title = "User List";

            var toolbarItem = new ToolbarItem
            {
                Text = "+"
            };

            toolbarItem.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new UserPage() { BindingContext = new User() });
            };

            ToolbarItems.Add(toolbarItem);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            UserListView.ItemsSource = await App.Database.GetUsersAsync();
        }

       async void User_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null) {
                await Navigation.PushAsync(new UserPage() { BindingContext = e.SelectedItem as User });
            }
        }
    }
}
