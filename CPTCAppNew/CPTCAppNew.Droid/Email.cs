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

namespace CPTCAppNew.Droid
{
    [Activity(Label = "Email")]
    public class Email : Activity
    {
        WebView browser;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Id.email);
            browser = FindViewById<WebView>(Resource.Id.emailWebView);
            browser.Settings.JavaScriptEnabled = true;
            browser.LoadUrl("http://gmail.com");

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

        // Create your application here
    }
    
}