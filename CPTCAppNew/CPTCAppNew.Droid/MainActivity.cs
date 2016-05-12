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
		int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //getMap(@"http://www.cptc.edu/sites/default/files/files/Lakewood%20Campus%20Map.jpeg", lakewoodMap);
            //var imageView = FindViewById<ImageView>(Resource.Id.map);
            //imageView.SetImageResource(Environment.SpecialFolder.Personal);
            var imageBitmap = GetImageBitmapFromUrl("http://www.cptc.edu/sites/default/files/files/Lakewood%20Campus%20Map.jpeg");
            ImageView imagen = FindViewById<ImageView>(Resource.Id.map);
            imagen.SetImageBitmap(imageBitmap);

            Button button = FindViewById<Button>(Resource.Id.myButton);
            
            button.Click += delegate
            {
                button.Text = string.Format("{0} clicks!", count++);
            };
        }

        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }

            return imageBitmap;
        }


        ////public void getMap(String Url, String fileName)
        //{
        //    var webclient = new WebClient();
        //    var directory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    var fileNameAndPath = Path.Combine(directory, fileName);
        //    webclient.DownloadData(URL, fileNameAndPath);
        //}

            

        

	}
}


