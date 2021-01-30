using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Porsche : ContentPage
    {
        public Porsche()
        {
            InitializeComponent();
        }
        private void Button_Porsche_911(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche911());
        }
        private void Button_Porsche_Le_Mans(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PorscheLeMans());
        }
        private void Button_Porsche_Racing(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PorscheRacing());
        }
    }
}