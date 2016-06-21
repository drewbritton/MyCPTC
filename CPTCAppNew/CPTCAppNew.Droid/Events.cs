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
    [Activity(Label = "Events")]
    public class Events : Activity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Events);
            EditText textTest = (EditText)FindViewById(Resource.Id.editText1);
            EditText textTest2 = (EditText)FindViewById(Resource.Id.editText2);
            SchoolEventsRepository events = new SchoolEventsRepository();
            List<SchoolEvents> list = await events.TopEventsAsync();
            textTest.Text = list[0].Name;
            textTest2.Text = list[1].Name;

            // Create your application here
        }
    }
}