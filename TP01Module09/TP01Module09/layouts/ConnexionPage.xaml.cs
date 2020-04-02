using System;
using TP01Module09.services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP01Module09.layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnexionPage : ContentPage
    {
        private ITwitterService twitterService = new TwitterService();

        public ConnexionPage()
        {
            InitializeComponent();
        }

        async void Connexion_Clicked(object sender, EventArgs e)
        {
            String username = this.identifiant.Text;
            String password = this.password.Text;
            bool remember_me = this.rememberme.IsToggled;

            this.errorIdentifiant.IsVisible = false;
            this.errorPassword.IsVisible = false;
            this.errorInternet.IsVisible = false;
            this.errorAuthenticate.IsVisible = false;

            if (!isFormValid(username, password))
            {
                return;
            }

            var connectivity = Connectivity.NetworkAccess;

            if (connectivity != NetworkAccess.Internet)
            {
                this.errorInternet.IsVisible = true;
                return;
            }

            if (!this.twitterService.authenticate(username, password))
            {
                this.errorAuthenticate.IsVisible = true;
                return;
            }

            await Navigation.PushAsync(new TweetListPage());
        }

        private bool isFormValid(String username, String password)
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(username) || username.Length < 3)
            {
                isValid = false;
                this.errorIdentifiant.IsVisible = true;
            }

            if (String.IsNullOrEmpty(password) || password.Length < 6)
            {
                isValid = false;
                this.errorPassword.IsVisible = true;
            }

            return isValid;
        }
    }
}