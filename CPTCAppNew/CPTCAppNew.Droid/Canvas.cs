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
using Android.Webkit;
using Java.Lang;
using Android.Content.PM;

namespace CPTCAppNew.Droid
{
    [Activity(Label = "Canvas", ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    
    public class Canvas : Activity
    {
        WebView browser;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            string username = Intent.GetStringExtra("canvasUsername");
            string password = Intent.GetStringExtra("canvasPassword");
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Canvas);
            browser = FindViewById<WebView>(Resource.Id.webView1);
            browser.Settings.JavaScriptEnabled = true;
            browser.LoadUrl("https://cptc.instructure.com/login/canvas");
            browser.SetWebViewClient(new WebViewClient());



    // Create your application here
}
        //protected void onSaveInstanceState(Bundle outState)
        //{
        //    ((WebView)FindViewById(Resource.Id.webView1)).SaveState(outState);
        //}

        public class HelloWebViewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                view.LoadUrl(url);
                return true;
            }
        }
    }
}