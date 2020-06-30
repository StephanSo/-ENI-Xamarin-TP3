using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace TP3
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
        private void Connection_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Test Connection");
            String LoginStr = this.login.Text;
            String PassStr = this.pass.Text;
            Boolean rememberVal = this.remember.IsToggled;

            this.errorLabel.IsVisible = false;

            if (String.IsNullOrEmpty(LoginStr) || LoginStr.Length< 3)
            {
                this.errorLabel.Text = "Veuillez entrer un login d'au moins 3 caractères";
                this.errorLabel.IsVisible = true;
                return;
            }

            if (String.IsNullOrEmpty(PassStr) || PassStr.Length < 6)
            {
                this.errorLabel.Text = "Veuillez entrer un mot de passe d'au moins 6 caractère";
                this.errorLabel.IsVisible = true;
                return;
            }

            this.form.IsVisible = false;
            this.tweets.IsVisible = true;
            this.form.IsEnabled = false;
            return;
        }
    }
}
