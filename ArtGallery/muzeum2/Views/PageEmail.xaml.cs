using System;
using System.Collections.Generic;
using Xamarin.Forms;
using muzeum2.ViewModels;


namespace muzeum2
{
    public partial class PageEmail : ContentPage
    {
        private PageEmailViewModel _vm;
        public PageEmail()
        {
            InitializeComponent();
            _vm = new PageEmailViewModel
            {
                Navigation = Navigation
            };
            BindingContext = _vm;

        }
    }
}
