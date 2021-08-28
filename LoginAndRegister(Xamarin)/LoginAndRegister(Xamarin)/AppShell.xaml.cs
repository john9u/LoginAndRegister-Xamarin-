using LoginAndRegister_Xamarin_.ViewModels;
using LoginAndRegister_Xamarin_.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LoginAndRegister_Xamarin_
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
