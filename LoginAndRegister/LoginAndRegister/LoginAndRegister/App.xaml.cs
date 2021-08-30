﻿using LoginAndRegister.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginAndRegister
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InitialPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
