using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindingDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FailLoginPage : ContentPage
    {
        public FailLoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();//This will take the user back to main page with login box to try again
        }
    }
}