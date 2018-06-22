using System;
using Xamarin.Forms;
using System.Text.RegularExpressions;
namespace muzeum2
{
    public class EmailValidationBehaviour : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += BindableOnTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.TextChanged -= BindableOnTextChanged;
        }

        private void BindableOnTextChanged(Object sender, TextChangedEventArgs e)
        {
            var email = e.NewTextValue;

            var emailPattern =
                "(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&\'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$";

            var emailEntry = sender as Entry;

            if(Regex.IsMatch(email, emailPattern))
            {
                emailEntry.BackgroundColor = Color.Green;
            }
            else
            {
                emailEntry.BackgroundColor = Color.Red;
            } 
        }
    }
}
