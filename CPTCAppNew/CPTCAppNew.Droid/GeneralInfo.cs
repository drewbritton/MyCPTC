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
using Android.Content.PM;
using Android.Webkit;

namespace CPTCAppNew.Droid
{
    [Activity(Label = "GeneralInfo", ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class GeneralInfo : Activity
    {
        WebView browser;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.info);
            browser = FindViewById<WebView>(Resource.Id.infowebView);
            browser.Settings.JavaScriptEnabled = true;
            browser.LoadUrl("http://catalog.cptc.edu/degrees");

            browser.SetWebViewClient(new WebViewClient());
            // Create your application here
        }
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