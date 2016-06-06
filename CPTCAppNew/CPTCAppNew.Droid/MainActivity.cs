using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace CPTCAppNew.Droid
{
	[Activity (Label = "CPTCAppNew.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button map = FindViewById<Button>(Resource.Id.map);            
            map.Click += delegate
            {
                StartActivity(typeof(Map));
            };
            Button settings = FindViewById<Button>(Resource.Id.settings);
            settings.Click += delegate
            {
                StartActivity(typeof(Settings));
            };
            ImageButton canvas = FindViewById<ImageButton>(Resource.Id.canvas);
            canvas.Click += delegate
            {
                StartActivity(typeof(Canvas));
            };
        }





	}
}


