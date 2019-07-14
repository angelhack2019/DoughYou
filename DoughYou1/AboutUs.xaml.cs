using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DoughYou1
{
    public partial class AboutUs : ContentPage
    {
        public AboutUs()
        {
            var title = new Label
            {
                Text = "About Us",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            var description = new Label
            {
                Text = "In 2015, we disposed 37.6 million tons of food waste. By managing food sustainably and reducing waste, DoughYou can help businesses and consumers save money, provide a bridge in our communities for those who do not have enough to eat, and conserve resources for future generations."
            };

            var blogTitle = new Label
            {
                Text = "In the News",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            List<string> articles = new List<string>
            {
                "DoughYou reduces foodscrapes"
            };

            ListView articlesView = new ListView
            {
                ItemsSource = articles
            };

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { title, description, blogTitle, articlesView }
            };

        }
    }
}
