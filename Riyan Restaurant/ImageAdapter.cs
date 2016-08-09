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
    public class ImageAdapter : BaseAdapter
    {
        Context context;

        public ImageAdapter(Context c)
        {
            context = c;
        }

        public override int Count { get { return thumbIds.Length; } }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView i = new ImageView(context);

            i.SetImageResource(thumbIds[position]);
            i.LayoutParameters = new Gallery.LayoutParams(1024, 720);
            i.SetScaleType(ImageView.ScaleType.FitXy);

            return i;
        }

        // references to our images
        int[] thumbIds = {
            Resource.Drawable.menu_1,
            Resource.Drawable.menuitem_1,
            Resource.Drawable.menuitem_2,
            Resource.Drawable.menuitem_3,
            Resource.Drawable.menuitem_4,
            Resource.Drawable.menuitem_5,
            Resource.Drawable.menuitem_6
     };
    }
}