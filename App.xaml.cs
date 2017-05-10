using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace prototype
{
    public partial class App : Application
    {
        static UserDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new UserListPage());
        }

        public static UserDatabase Database {
            get {
                if(database == null){
                    database = new UserDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("UserDb.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
