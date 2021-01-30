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
    public partial class Porsche911 : ContentPage
    {
        public Porsche911()
        {
            InitializeComponent();
        }
        private void Button_Porsche_91167(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche91167());
        }
        private void Button_Porsche_911_930T(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche911930T());
        }
        private void Button_Porsche_911_993RS(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche911993RS());
        }
        private void Button_Porsche_911_996GT3RS(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche911996GT3RS());
        }
        private void Button_Porsche_911_997GT3RS1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche911997GT3RS());
        }
        private void Button_Porsche_911_997GT3RS2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche911997GT3RS2());
        }
        private void Button_Porsche_911_997GT3RS4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche911997GT3RS4());
        }
        private void Button_Porsche_911_991GT3RS1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche911991GT3RS());
        }
        private void Button_Porsche_911_991GT3RS2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche911991GT3RS2());
        }
    }
}