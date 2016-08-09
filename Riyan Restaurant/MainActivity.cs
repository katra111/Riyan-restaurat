using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Riyan_Restaurant
{
    [Activity(Label = "Riyan Restaurant", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            Button button1 = FindViewById<Button>(Resource.Id.Button1);
            Button button2 = FindViewById<Button>(Resource.Id.Button2);
            Button button3 = FindViewById<Button>(Resource.Id.Button3);
            Button button4 = FindViewById<Button>(Resource.Id.Button4);
            Button button5 = FindViewById<Button>(Resource.Id.Button5);

            button1.Click += delegate { StartActivity(typeof(Activity3)); };
            button2.Click += delegate { StartActivity(typeof(Activity2)); };
            button3.Click += delegate { StartActivity(typeof(Activity4)); };
            button4.Click += delegate { StartActivity(typeof(Activity1)); };
            button5.Click += delegate { StartActivity(typeof(Activity5)); };

        }
    }
}

