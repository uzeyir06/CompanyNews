﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompanyNews
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()) { Title = "Company News" };
            NavigationPage.SetHasNavigationBar(this, false);
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
