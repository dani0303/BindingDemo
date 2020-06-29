using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindingDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Action DisplayInvalidPrompt;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel20();
            BindingContext = new MVVM3();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TabbedPage1());
        }

        /*public void Button_Clicked(object sender, EventArgs e)
        {
            if (MVVM3.password.Equals("Test") && MainViewModel20.username.Equals("Test"))
            {
                Navigation.PushModalAsync(new TabbedPage());
            }
            else
                Navigation.PushModalAsync(new FailLoginPage());
        }*/
    }
}
