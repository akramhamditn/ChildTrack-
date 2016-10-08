using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestDevise
{
    public partial class InscritPage : ContentPage
    {
        public InscritPage()
        {
            InitializeComponent();

        }
        void addChildClic(object sender, EventArgs args)
        {

            DisplayAlert("Alert", "Application is in beta version use *username :'admin' and *Password :'admin' for parents                 *username :'child' and *Password :'child' for child                            Enjoy :)", "OK");


        }
    }
}
