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
	[Activity (Label = "CPTCAppNew.Droid", MainLauncher = true, Icon = "@drawable/icon", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
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
            Button canvas = FindViewById<Button>(Resource.Id.btn_canvas);
            canvas.Click += delegate
            {
                StartActivity(typeof(Canvas));
            };
            Button email = FindViewById<Button>(Resource.Id.email);
            email.Click += delegate
            {
                StartActivity(typeof(Email));
            };
            Button events = FindViewById<Button>(Resource.Id.events);
            events.Click += delegate
            {
                StartActivity(typeof(Events));
            };
            Button generalInfo = FindViewById<Button>(Resource.Id.info);
            generalInfo.Click += delegate
            {
                StartActivity(typeof(GeneralInfo));
            };
        }
    }





	
}


