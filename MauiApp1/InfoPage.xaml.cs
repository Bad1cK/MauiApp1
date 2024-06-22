using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MainPage mainPage)
            {
                mainPage.FindByName<ContentView>("MainContentArea").Content = new Label
                {
                    Text = "Welcome to the main content area!",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center
                };
            }
        }
    }
}
