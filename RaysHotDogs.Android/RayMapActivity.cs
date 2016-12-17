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

namespace RaysHotDogs.Android
{
    [Activity(Label = "Visit Ray's store")]
    public class RayMapActivity : Activity
    {
        private Button externalMapButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.RayMapView);

            FindViews();

            HandleEvents();

        }

        private void FindViews()
        {
            externalMapButton = FindViewById<Button>(Resource.Id.externalMapButton);
        }

        private void HandleEvents()
        {
            externalMapButton.Click += ExternalMapButton_Click;
        }

        private void ExternalMapButton_Click(object sender, EventArgs e)
        {
            global::Android.Net.Uri rayLocationUri = global::Android.Net.Uri.Parse("geo:41.904759, 12.482938");
            Intent mapIntent = new Intent(Intent.ActionView, rayLocationUri);
            StartActivity(mapIntent);
        }
    }
}