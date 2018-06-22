using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using muzeum2.ViewModels;

namespace muzeum2
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel _vm;
        public MainPage()
        {
            InitializeComponent();


            _vm = new MainPageViewModel
            {
                Navigation = Navigation
            };
            BindingContext = _vm;
        }
    }
}
