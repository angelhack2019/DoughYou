using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DoughYou1
{
    public partial class Homepage : ContentPage
    {
        public Homepage()
        {



            var title = new Label
            {
                Text = "Welcome to DoughYou!",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            var aboutButton = new Button
            {
                Text = "About Us"
            };

            var signupButton = new Button
            {
                Text = "Sign Up"
            };

            //goes to the about us page when the user clicks the about us button
            aboutButton.Clicked += (object sender, EventArgs e) =>
            {
                Navigation.PushAsync(new AboutUs());
            };

            signupButton.Clicked += (object sender, EventArgs e) =>
            {
                Navigation.PushAsync(new RegistrationPage());
            };

            var email = new Entry
            {
                Placeholder = "E-mail",
            };

            var password = new Entry
            {
                Placeholder = "Password",
                IsPassword = true
            };

            var login = new Button
            {
                Text = "Log in"
            };



            Content = new StackLayout
            {
                Margin = new Thickness(10,10,10,10),
                //Padding = 10,
                //Spacing = 10,
                Children = { title, email, password, login, signupButton, aboutButton }
            };

            
            //ScrollBarVisibility.ScrollToAsync(label, ScrollToPosition.Start, true);
            //InitializeComponent();
        }
    }
}
