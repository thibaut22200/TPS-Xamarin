using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP01Module06
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Connexion_Clicked(object sender, EventArgs e)
        {
            String identifiant = this.identifiant.Text;
            String password = this.password.Text;
            bool remember_me = this.rememberme.IsToggled;

            this.errorIdentifiant.IsVisible = false;
            this.errorPassword.IsVisible = false;

            bool errorExist = false;
            if(String.IsNullOrEmpty(identifiant) || identifiant.Length < 3)
            {
                errorExist = true;
                this.errorIdentifiant.IsVisible = true;
            }

            if(String.IsNullOrEmpty(password) || password.Length < 6)
            {
                errorExist = true;
                this.errorPassword.IsVisible = true;
            }

            if (errorExist) { return; }
            this.tweetsLayout.IsVisible = true;
            this.connexionLayout.IsVisible = false;
            return;
        }
    }
}
