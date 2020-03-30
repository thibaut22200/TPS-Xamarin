using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01Module07.services;
using Xamarin.Forms;

namespace TP01Module07
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterService twitterService = new TwitterService();
        public MainPage()
        {
            InitializeComponent();
        }

        private void Connexion_Clicked(object sender, EventArgs e)
        {
            String username = this.identifiant.Text;
            String password = this.password.Text;
            bool remember_me = this.rememberme.IsToggled;

            this.errorIdentifiant.IsVisible = false;
            this.errorPassword.IsVisible = false;

            if (!isFormValid(username, password))
            {
                return;
            }

            if (!this.twitterService.authenticate(username, password))
            {
                this.errorAuthenticate.IsVisible = true;
                return;
            }

            this.tweetsLayout.IsVisible = true;
            this.connexionLayout.IsVisible = false;
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
