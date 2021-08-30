using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LoginAndRegister.Models
{
    
    public class MenuOption : INotifyPropertyChanged
    {
        public MenuOption(string title, string image)
        {
            Title = title;
            Image = image;
        }

        public string Title { get; set; }
        public string Image { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
