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
            EditText events2box1 = (EditText)FindViewById(Resource.Id.editText3);
            EditText events2box2 = (EditText)FindViewById(Resource.Id.editText4);
            EditText events3box1 = (EditText)FindViewById(Resource.Id.editText5);
            EditText events3box2 = (EditText)FindViewById(Resource.Id.editText6);
            SchoolEventsRepository events = new SchoolEventsRepository();
            List<SchoolEvents> list = await events.TopEventsAsync();
            textTest.Text = "Event: " + list[0].Name + "    Date: " + list[0].DateOfEvent;
            textTest2.Text = "Description: " + list[0].Description + "    Cost: $" + list[0].PriceOfAdmission;
            events2box1.Text = "Event: " + list[1].Name + "    Date: " + list[1].DateOfEvent;
            events2box2.Text = "Description: " + list[1].Description + "    Cost: $" + list[1].PriceOfAdmission;
            events3box1.Text = "Event: " + list[2].Name + "    Date: " + list[2].DateOfEvent;
            events3box2.Text = "Description: " + list[2].Description + "    Cost: $" + list[2].PriceOfAdmission;

            // Create your application here
        }
    }
}