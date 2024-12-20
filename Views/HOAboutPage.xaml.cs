using System;
using Microsoft.Maui.Controls;

namespace HansOrtizApuntes.Views;

public partial class HOAboutPage : ContentPage
{
    public HOAboutPage()
    {
        InitializeComponent();
    }

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.HOAbout about)
        {
            // Navigate to the specified URL in the system browser
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
}