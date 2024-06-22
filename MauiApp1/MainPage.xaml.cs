using Microsoft.Maui.Controls;
using System;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private bool _isExpanded = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnProfileButtonClicked(object sender, EventArgs e)
        {
            if (_isExpanded)
            {
                HideExpandableButtons();
            }
            else
            {
                ShowExpandableButtons();
            }
            _isExpanded = !_isExpanded;
        }

        private async void ShowExpandableButtons()
        {
            if (ExpandableButtons != null)
            {
                ExpandableButtons.IsVisible = true;
                await ExpandableButtons.FadeTo(1, 250); // Animate the opacity to 1 over 250 milliseconds
            }
        }

        private async void HideExpandableButtons()
        {
            if (ExpandableButtons != null)
            {
                await ExpandableButtons.FadeTo(0, 250); // Animate the opacity to 0 over 250 milliseconds
                ExpandableButtons.IsVisible = false;
            }
        }

        private void OnWalletButtonClicked(object sender, EventArgs e)
        {
            if (MainContentArea != null)
            {
                MainContentArea.Content = new WalletPage().Content;
            }
        }

        private void OnStatsButtonClicked(object sender, EventArgs e)
        {
            if (MainContentArea != null)
            {
                MainContentArea.Content = new StatsPage().Content;
            }
        }

        private void OnTradingButtonClicked(object sender, EventArgs e)
        {
            if (MainContentArea != null)
            {
                MainContentArea.Content = new TradingPage().Content;
            }
        }

        private void OnTutorialButtonClicked(object sender, EventArgs e)
        {
            if (MainContentArea != null)
            {
                MainContentArea.Content = new InfoPage().Content;
            }
        }

        private void OnCloseButtonClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
