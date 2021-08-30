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
    class RegisterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IAlertService _alertservice;
        public ICommand SubmitCommand { protected set; get; }
        public ICommand NavigateCommand { protected set; get; }
        public RegisterViewModel(IAlertService alertservice)
        {
            _alertservice = alertservice;
            SubmitCommand = new Command(OnSubmit);
            
        }

        public Register User { get; set; } = new Register(string.Empty, string.Empty,string.Empty, string.Empty);

        public async void OnSubmit()
        {
            if (string.IsNullOrEmpty(User.Name) || string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Password) || string.IsNullOrEmpty(User.RepeatPassword))
            {
                await _alertservice.Alert("Error", "Existen campos vacios", "OK");
            }
            else if (User.Password!=User.RepeatPassword)
            {
                await _alertservice.Alert("Error", "Contraseña no coincide", "OK");
            }
            else
            {
                
                await _alertservice.Alert("Bienvenido", $"Has sido registrado {User.Name}", "OK");
                await App.Current.MainPage.Navigation.PushAsync(new InitialPage());
            }
        }
    }
}
