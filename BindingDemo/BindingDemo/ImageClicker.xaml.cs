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
    public partial class Page2 : ContentPage
    {
        public Page2()//each function pulls up the image in fullscreen
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page2Child3());
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page2Child2());
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page2Child1());
        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page2Child());
        }
    }
}