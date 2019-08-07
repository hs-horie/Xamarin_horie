using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin_horie
{
    public partial class LayoutPage : ContentPage
    {
        public LayoutPage()
        {
            InitializeComponent();

            GridButton.Clicked += GridButton_Clicked;
        }

        void GridButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridPage());
        }

    }
}
