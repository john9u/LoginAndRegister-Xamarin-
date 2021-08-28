using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace LoginAndRegister.Models
{
    class Register : INotifyPropertyChanged
    {
        public Register(string name, string email, string pasdword, string reapeatPassword)
        {
            Name = name;
            Email = email;
            Password = pasdword;
            RepeatPassword = reapeatPassword;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
