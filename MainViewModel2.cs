using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BindingDemo
{
    public class MainViewModel2 : INotifyPropertyChanged
    {
        string email = string.Empty;

        public string Email
        {
            get => email;
            set
            {
                if (email == value)
                    return;

                email = value;
                OnPropertyChanged(nameof(Email));
                OnPropertyChanged(nameof(DisplayEmail));
            }
        }

        public string DisplayEmail => $"Email Entered:{Email}";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string email)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(email));
        }
    }
}
