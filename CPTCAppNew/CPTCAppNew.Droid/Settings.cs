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
            EditText emailUsername = (EditText)FindViewById(Resource.Id.emailAddress);
            EditText emailPassword = (EditText)FindViewById(Resource.Id.emailPassword);
            Button emailsave = FindViewById<Button>(Resource.Id.emailSave);
            emailsave.Click += delegate
            {

                string saveUserName = emailUsername.Text;
                string savePassword = emailPassword.Text;
                emailUsername.Text = "";
                if (emailUsername.Text.Trim().Length > 0 && emailPassword.Text.Trim().Length > 0)
                {
                    emailUsername.Hint = ("Email Address Saved");
                }
            };
            EditText canvasUser = (EditText)FindViewById(Resource.Id.canvasUserName);
            EditText canvasPass = (EditText)FindViewById(Resource.Id.canvasPassword);
            Button canvasSave = FindViewById<Button>(Resource.Id.canvasSave);
            canvasSave.Click += delegate
            {

                string canvasUserName = canvasUser.Text;
                string canvasPassword = canvasPass.Text;
                canvasUser.Text = "";
                if (canvasUser.Text.Trim().Length > 0 && canvasPass.Text.Trim().Length > 0)
                {
                    canvasUser.Hint = ("Canvas Login Saved");
                    Intent canvasIntent = new Intent(this, typeof(Canvas));
                    canvasIntent.PutExtra("canvasUsername", canvasUserName);
                    canvasIntent.PutExtra("canvasPassword", canvasPassword);
                }
            };
        }
    }
}