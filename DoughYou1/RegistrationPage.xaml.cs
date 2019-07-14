using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DoughYou1
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {

            var email = new Entry
            {
                Placeholder = "Email"
            };

            var password = new Entry
            {
                Placeholder = "Password",
                IsPassword = true //to hide the password from being displayed
            };
            //InitializeComponent();

            var signupButton = new Button
            {
                Text = "Sign Up"
            };

            signupButton.Clicked += (object sender, EventArgs e) =>
            {

            };

         

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children =
                {
                    new Label { Text = "Sign Up for a DoughYou account today!", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), HorizontalOptions = LayoutOptions.Center },
                        email,
                        password,
                        signupButton
                    }
                };
        }
    }
}
