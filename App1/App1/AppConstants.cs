using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1
{
    public class AppConstants
    {
        public static string AppId 
        {
            get 
            {
                switch (Device.RuntimePlatform) 
                {
                    case Device.Android:
                        return "ca-app-pub-1429554340944087~8807424815";
                    default:
                        return "ca-app-pub-1429554340944087~8807424815";
                }
            }
        }

        public static string BannerId 
        {
            get 
            {
                switch (Device.RuntimePlatform) 
                {
                    case Device.Android:
                        return "ca-app-pub-1429554340944087/8320339659";
                    default:
                        return "ca-app-pub-1429554340944087/8320339659";
                }
            }
        }
    }
}
