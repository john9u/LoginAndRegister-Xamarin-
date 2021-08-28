using LoginAndRegister.Services;
using LoginAndRegister.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginAndRegister.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            this.BindingContext = new RegisterViewModel(new AlertService());
            InitializeComponent();

        }
    }
}