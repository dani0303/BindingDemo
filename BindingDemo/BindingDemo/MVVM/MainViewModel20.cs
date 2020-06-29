using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Xamarin.Forms.Xaml;

namespace BindingDemo
{
    class MainViewModel20 : INotifyPropertyChanged

    {
        public static string username = string.Empty;
        public string Username
        {
            get => username;
            set
            {
                if (username == value)
                    return;

                username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string DisplayUsername => $"Password Entered:{Username}";

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string username)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(username));
        }
    }
}
