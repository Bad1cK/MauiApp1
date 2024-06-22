using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void OnTutorialButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new InfoPage();
        }
    }
}
