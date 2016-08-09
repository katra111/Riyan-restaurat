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
    public class Activity5 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout5);

            Button button1 = FindViewById<Button>(Resource.Id.ConfirmButton);
            button1.Click += delegate { StartActivity(typeof(Activity6)); };

        }
    }
}