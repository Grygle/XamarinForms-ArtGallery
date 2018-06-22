using System;

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
//using muzeum2.Models;
using System.Resources;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace muzeum2.ViewModels
{
    public class PageObrazyViewModel
    {
        public ICommand NavigateToNightWatchCommand { get; set; }
        public ICommand NavigateToScreamCommand { get; set; }
        public ICommand NavigateToStarryNightCommand { get; set; }
        public ICommand NavigateToTheAncientOfDaysCommand { get; set; }
        public ICommand NavigateToAllegoryOfPrudenceCommand { get; set; }
        public ICommand NavigateToApplesAndJarCommand { get; set; }
        public ICommand NavigateToOddsAndEndsCommand { get; set; }
        public ICommand NavigateToSelfPortraitCommand { get; set; }
        public ICommand NavigateToSpringTimeCommand { get; set; }
        public ICommand NavigateToTheStormOnTheSeaOfGalileeCommand { get; set; }
        public ICommand NavigateToTheFourTimesOfDayNightCommand { get; set; }
        public ICommand NavigateToTheMilkmaidCommand { get; set; }

        public INavigation Navigation;
        public PageObrazyViewModel()
        {
            NavigateToNightWatchCommand = new Command(NavigateToNightWatch);
            NavigateToScreamCommand = new Command(NavigateToScream);
            NavigateToStarryNightCommand = new Command(NavigateToStarryNight);
            NavigateToTheAncientOfDaysCommand = new Command(NavigateToTheAncientOfDays);
            NavigateToAllegoryOfPrudenceCommand = new Command(NavigateToAllegoryOfPrudence);
            NavigateToApplesAndJarCommand = new Command(NavigateToApplesAndJar);
            NavigateToOddsAndEndsCommand = new Command(NavigateToOddsAndEnds);
            NavigateToSelfPortraitCommand = new Command(NavigateToSelfPortrait);
            NavigateToSpringTimeCommand = new Command(NavigateToSpringTime);
            NavigateToTheStormOnTheSeaOfGalileeCommand = new Command(NavigateToTheStormOnTheSeaOfGalilee);
            NavigateToTheFourTimesOfDayNightCommand = new Command(NavigateToTheFourTimesOfDayNight);
            NavigateToTheMilkmaidCommand = new Command(NavigateToTheMilkmaid);

        }

        private async void NavigateToNightWatch()
        {
            //await Navigation.PushModalAsync(new PageObrazy());
            await Navigation.PushAsync(new TheNightWatch());
        }
        private async void NavigateToScream()
        {
            await Navigation.PushAsync(new Page3());
        }
        private async void NavigateToStarryNight()
        {
            await Navigation.PushAsync(new StarryNight());
        }
        private async void NavigateToTheAncientOfDays()
        {
            await Navigation.PushAsync(new TheAncientOfDays());
        }
        private async void NavigateToAllegoryOfPrudence()
        {
            await Navigation.PushAsync(new AllegoryOfPrudence());
        }
        private async void NavigateToApplesAndJar()
        {
            await Navigation.PushAsync(new ApplesAndJar());
        }
        private async void NavigateToOddsAndEnds()
        {
            await Navigation.PushAsync(new OddsAndEnds());
        }
        private async void NavigateToSelfPortrait()
        {
            await Navigation.PushAsync(new SelfPortrait());
        }
        private async void NavigateToSpringTime()
        {
            await Navigation.PushAsync(new SpringTime());
        }
        private async void NavigateToTheStormOnTheSeaOfGalilee()
        {
            await Navigation.PushAsync(new TheElephants());
        }
        private async void NavigateToTheFourTimesOfDayNight()
        {
            await Navigation.PushAsync(new TheFourTimesOfDayNight());
        }
        private async void NavigateToTheMilkmaid()
        {
            await Navigation.PushAsync(new TheMilkmaid());
        }
    }
}
