using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LoginAndRegister.Models
{
    class User :INotifyPropertyChanged
    {
            public User(string userName, string password)
            {
                UserName = userName;
                Password = password;
            }

            public string UserName { get; set; }
            public string Password { get; set; }


            public event PropertyChangedEventHandler PropertyChanged;
        
    }
}
