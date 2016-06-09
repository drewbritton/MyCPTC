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

namespace CPTCAppNew.Droid
{
    [Activity(Label = "Settings")]
    public class Settings : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Settings);
            EditText username = (EditText)FindViewById(Resource.Id.emailAddress);
            EditText password = (EditText)FindViewById(Resource.Id.emailPassword);
            Button emailsave = FindViewById<Button>(Resource.Id.emailSave);
            emailsave.Click += delegate
            {

                string saveUserName = username.Text;
                string savePassword = password.Text;
                username.Text = "";
                if (saveUserName != null && savePassword != null)
                {
                    username.Hint = ("Email Address Saved");
                }
            };
            username.Click += delegate
            {
                username.SetCursorVisible(true);
            };
        }
    }
}