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
using RaysHotDogs.Core.Model;
using RaysHotDogs.Android.Utility;

namespace RaysHotDogs.Android.Adapters
{
    public class HotDogListAdapter : BaseAdapter<HotDog>
    {
        List<HotDog> items;
        Activity context;

        public HotDogListAdapter(Activity context, List<HotDog> items) : base()
        {
            this.context = context;
            this.items = items;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override HotDog this[int position]
        {
            get { return items[position]; }
        }

        public override int Count
        {
            get
            {
                return items.Count;
            }

        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];

            var imageBitmap = ImageHelper.GetImageBitMapFromUrl("http://gillcleerenpluralsight.blob.core.windows.net/files/" + item.ImagePath + ".jpg");

            if (convertView == null)
            {
                convertView = context.LayoutInflater.Inflate(global::Android.Resource.Layout.ActivityListItem, null);
            }

            convertView.FindViewById<TextView>(global::Android.Resource.Id.Text1).Text = item.Name;
            convertView.FindViewById<ImageView>(global::Android.Resource.Id.Icon).SetImageBitmap(imageBitmap);

            return convertView;
        }
    }
}