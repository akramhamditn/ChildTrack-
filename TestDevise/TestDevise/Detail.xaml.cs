using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace TestDevise
{
    public partial class Detail : ContentPage
    {
        private Person person;

        public Detail()
        {
            InitializeComponent();
            var map = new Map(
            MapSpan.FromCenterAndRadius(
                    new Position(36.8959702, 10.1861338), Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
            var position = new Position(36.8959702, 10.1861338); // Latitude, Longitude
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Your Child",
                Address = "custom detail info"
            };
            map.Pins.Add(pin);
        }

       
    }
}
