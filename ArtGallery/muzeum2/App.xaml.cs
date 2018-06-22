using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Diagnostics;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace muzeum2
{
    public partial class App : Application
    {

        public App()
        {
           // InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            Debug.WriteLine("Uruchomienie");
            Debug.WriteLine(DateTime.Now);
            // Handle when your app starts
        }

        protected async override void OnSleep()
        {
  
            // Handle when your app sleeps
            await MainPage.Navigation.PopToRootAsync(true);
            Debug.WriteLine("Uspienie");
        }

        protected async override void OnResume()
        {

            Debug.WriteLine("Wznowienie");
            var nav = MainPage.Navigation;
            await nav.PushAsync(new PageObrazy());
        }
    }
}
