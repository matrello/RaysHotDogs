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
using RaysHotDogs.Core.Service;
using RaysHotDogs.Android.Adapters;

namespace RaysHotDogs.Android
{
    [Activity(Label = "Hot Dog Menu", MainLauncher = true)]
    public class HotDogMenuActivity : Activity
    {
        private ListView hotdogListView;
        private List<HotDog> allHotDogs;
        private HotDogDataService hotDogDataService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.HotDogMenuView);

            hotdogListView = FindViewById<ListView>(Resource.Id.hotDogListView);
            hotDogDataService = new HotDogDataService();

            allHotDogs = hotDogDataService.GetAllHotDogs();

            hotdogListView.Adapter = new HotDogListAdapter(this, allHotDogs);

            hotdogListView.FastScrollEnabled = true;
        }
    }
}