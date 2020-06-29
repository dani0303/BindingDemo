using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace BindingDemo
{
    public class MVVM3 : INotifyPropertyChanged
    {

        public static string password = string.Empty;

        public string Password
        {
            get => password;
            set
            {
                if (password == value)
                    return;


                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string DisplayUsername => $"Password Entered:{Password}";
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string password)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(password));
        }
    }
}
