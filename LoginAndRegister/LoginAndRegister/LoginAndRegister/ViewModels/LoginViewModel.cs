using LoginAndRegister.Models;
using LoginAndRegister.Services;
using LoginAndRegister.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginAndRegister.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IAlertService _alertservice;
        public ICommand SubmitCommand { protected set; get; }
        public ICommand NavigateCommand { protected set; get; }
        public LoginViewModel(IAlertService alertservice)
        {
            _alertservice = alertservice;
            SubmitCommand = new Command(OnSubmit);
            NavigateCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());

            });
        }

        public User User { get; set; } = new User(string.Empty, string.Empty);

        public async void OnSubmit()
        {
            if (string.IsNullOrEmpty(User.UserName) || string.IsNullOrEmpty(User.Password))
            {
                await _alertservice.Alert("Error", "Existen campos vacios", "OK");
            }
            else
            {
                await _alertservice.Alert("Bienvenido", $"Hola {User.UserName}", "OK");
            }
        }
        
    }
}
