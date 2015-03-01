using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Lotus
{
    [Activity(Label = "ºÉLotus",Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    public class splashscreen : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            base.OnCreate(bundle);
            Thread.Sleep(2000); // Simulate a long loading process on app startup.
            StartActivity(typeof(MainActivity));
        }
    }
}