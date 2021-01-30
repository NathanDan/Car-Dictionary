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
    public partial class PorscheLeMans : ContentPage
    {
        public PorscheLeMans()
        {
            InitializeComponent();
        }
        private void Button_Porsche_924_Carrera_GTP(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche924CGTP());
        }
        private void Button_Porsche_911_Carrera_RSR_Turbo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche911CRSRT());
        }
        private void Button_Porsche_91720_Pink_Pig(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche91720PP());
        }
        private void Button_Porsche_917K_Short_Tail(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche917KST());
        }
        private void Button_Porsche_919_HY(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche919HY());
        }
        private void Button_Porsche_356_SL(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche356SL());
        }
        private void Button_Porsche_911_RSR_GTE_PRO(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Porsche356SL());
        }

    }
}