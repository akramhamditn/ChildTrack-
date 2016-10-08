using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestDevise
{
    public partial class ListEnfans : ContentPage
    {
        public ListEnfans()
        {
            InitializeComponent();
            MainListView.IsPullToRefreshEnabled = true;
            MainListView.ItemTemplate = new DataTemplate(typeof(CustomCell));
            MainListView.ItemsSource = new List<Person>
            {
                new Person
                {
                    Name="Akram",
                    Etat="Good"

                },
                new Person
                {
                    Name="Haythem",
                    Etat="On the way"

                },new Person
                {
                    Name="Chayma",
                    Etat="In School"

                },
            };
            MainListView.ItemSelected += async (sender, e) =>
            {
                if (MainListView.SelectedItem == null)
                    return;


                await Navigation.PushAsync(new Detail());

                MainListView.SelectedItem = null;
            };
        }
    }
}
