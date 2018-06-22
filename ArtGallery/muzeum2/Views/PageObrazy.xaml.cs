using System;
using System.Collections.Generic;
using Xamarin.Forms;
using muzeum2.ViewModels;


namespace muzeum2
{
    public partial class PageObrazy : ContentPage
    {
        private PageObrazyViewModel _vm;
        public PageObrazy()
        {
            InitializeComponent();
            _vm = new PageObrazyViewModel
            {
                Navigation = Navigation
            };
            BindingContext = _vm;
        
        }
    }
}