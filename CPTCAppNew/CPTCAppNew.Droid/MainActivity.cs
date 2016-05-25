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
            map.Click += delegate
            {
                StartActivity(typeof(Settings));
            };
        }



        //private Bitmap getImageHtml(String url)
        //{

        //    byte[] imageBytes;
        //    HttpWebRequest imageRequest = (HttpWebRequest)WebRequest.Create(url);
        //    WebResponse imageResponse = imageRequest.GetResponse();

        //    Stream responseStream = imageResponse.GetResponseStream();

        //    using (BinaryReader br = new BinaryReader(responseStream))
        //    {
        //        imageBytes = br.ReadBytes(500000);
        //        br.Close();
        //    }
        //    responseStream.Close();
        //    imageResponse.Close();

        //    FileStream fs = new FileStream(Android.OS.Environment.DirectoryPictures, FileMode.Create);
        //    BinaryWriter bw = new BinaryWriter(fs);
        //    try
        //    {
        //        bw.Write(imageBytes);
        //        Bitmap newImage = null;
        //        newImage = (Bitmap)imageBytes;
        //        return newImage;
        //    }
        //    finally
        //    {
        //        fs.Close();
        //        bw.Close();
                
        //    }
        //}



	}
}


