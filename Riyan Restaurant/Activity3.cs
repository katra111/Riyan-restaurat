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
    public class Activity3 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout3);

            Gallery gallery = (Gallery)FindViewById<Gallery>(Resource.Id.galleryview);

            gallery.Adapter = new ImageAdapter(this);

            gallery.ItemClick += delegate (object sender, Android.Widget.AdapterView.ItemClickEventArgs args)
            {
                if (args.Position == 0)
                    Toast.MakeText(this, "Menu", ToastLength.Short).Show();
                else if (args.Position == 1)
                    Toast.MakeText(this, "Cod Fillet Fish and Chips [1]", ToastLength.Long).Show();
                else if (args.Position == 2)
                    Toast.MakeText(this, "Fish & Chips [2]", ToastLength.Long).Show();
                else if (args.Position == 3)
                    Toast.MakeText(this, "Beef Lasagna [3]", ToastLength.Long).Show();
                else if (args.Position == 4)
                    Toast.MakeText(this, "Grilled Salomon [4]", ToastLength.Long).Show();
                else if (args.Position == 5)
                    Toast.MakeText(this, "Spinach Lasagna [5]", ToastLength.Long).Show();
                else if (args.Position == 6)
                    Toast.MakeText(this, "Bangers & Mash [6]", ToastLength.Long).Show();
            };

        }
    }
}