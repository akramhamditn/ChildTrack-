using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestDevise
{
    public partial class MainPage : ContentPage
    {


        public Color BarBackgroundColor { get; internal set; }
        public Color BarTextColor { get; internal set; }
        public MainPage()
        {
            InitializeComponent();
           
        }
        void LoginClic(object sender, EventArgs args)
        {
            if ((userName.Text == null) || (passeWD.Text==null))
            {
                DisplayAlert("Alert", "Check your infomations !!", "OK");
            }
            else if ((userName.Text == "child") && (passeWD.Text == "child"))
            {
                Navigation.PushAsync(new ChildPage());
            }
            else if ((userName.Text == "admin") && (passeWD.Text == "admin"))
            {
                Navigation.PushAsync(new ListEnfans());
            }
            
        }
        void RegisterClic(object sender, EventArgs args)
        {
            
                Navigation.PushAsync(new InscritPage());
            

        }

    }
}
