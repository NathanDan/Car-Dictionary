﻿using App1.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_All_Cars(object sender, EventArgs e) 
        {
            
        }

        private void Button_Porsche(object sender, EventArgs e) 
        {
            Navigation.PushAsync(new Porsche());
        }

        private void Button_Nissan(object sender, EventArgs e)
        { 
        }

        private void Button_Mercedes(object sender, EventArgs e) 
        {
        }

        
    }
}
