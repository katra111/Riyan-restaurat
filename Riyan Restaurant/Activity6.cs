using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Riyan_Restaurant
{
    [Activity(Label = "Riyan Restaurant")]
    public class Activity6 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout6);

            Button button1 = FindViewById<Button>(Resource.Id.PayButton);
            button1.Click += delegate { Toast.MakeText(this, "Order Placed", ToastLength.Long).Show(); };
            // Create your application here
        }
    }
}