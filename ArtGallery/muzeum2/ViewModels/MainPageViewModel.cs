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

namespace muzeum2.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand NavigateToMainCommand { get; set; }
        public ICommand NavigateToEmailCommand { get; set; }
        public INavigation Navigation;
        public MainPageViewModel()
        {
            NavigateToMainCommand = new Command(NavigateToMain);
            NavigateToEmailCommand = new Command(NavigateToEmail);
        }

        private async void NavigateToMain()
        {
            await Navigation.PushAsync(new PageObrazy());
        }
        private async void NavigateToEmail()
        {
            await Navigation.PushAsync(new PageEmail());
        }

    }
}
