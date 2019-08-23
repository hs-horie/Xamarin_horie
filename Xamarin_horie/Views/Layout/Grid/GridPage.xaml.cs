using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin_horie
{
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();

            AutoButton.Clicked += AutoButton_Clicked;
            PixelButton.Clicked += PixelButton_Clicked;
            StarButton.Clicked += StarButton_Clicked;
            DefaultButton.Clicked += DefaultButton_Clicked;
        }

        void DefaultButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DefaultPage());
        }


        void StarButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StarPage());
        }


        void PixelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PixelPage());
        }


        void AutoButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AutoPage());
        }

    }
}
