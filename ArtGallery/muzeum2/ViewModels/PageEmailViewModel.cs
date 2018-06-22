using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using muzeum2.Models;
using System.Resources;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using Plugin.Messaging;

namespace muzeum2.ViewModels
{
    public class PageEmailViewModel
    {
        public ICommand NavigateToValidationCommand { get; set; }

        public ICommand NavigateToEmailCommand { get; set; }
        public INavigation Navigation;
        public PageEmailViewModel()
        {
            NavigateToValidationCommand = new Command(NavigateToValidation);
            NavigateToEmailCommand = new Command(NavigateToEmail);
        }

        private async void NavigateToValidation()
        {
            await Navigation.PushAsync(new UsingBehavioursPage());
        }

 
        private void NavigateToEmail()
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                var email = new EmailMessageBuilder()
                  .To("julek200@gmail.com")
                  .Subject("Ocena aplikacji")
                  .Body("Super Aplikacja!")
                  .Build();

                emailMessenger.SendEmail(email);
            }
        }
    }
}
