using LoginAndRegister_Xamarin_.Services;
using LoginAndRegister_Xamarin_.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginAndRegister_Xamarin_
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
