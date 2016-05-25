using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Java.IO;
using System.IO;

namespace CPTCAppNew.Droid
{
    [Activity(Label = "Map")]
    public class Map : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Map);

            var imageBitmap = getImageBitmapFromUrl("http://www.cptc.edu/sites/default/files/files/Lakewood%20Campus%20Map.jpeg");
            ExportBitmapAsPNG(imageBitmap, "lakewoodMap");
            ImageView imagen = FindViewById<ImageView>(Resource.Id.map);
            String photoPath = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath + "/lakewoodMap.png";
            Bitmap bitmap1 = BitmapFactory.DecodeFile(photoPath);
            imagen.SetImageBitmap(bitmap1);
        }

        private Bitmap getImageBitmapFromUrl(string url)
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
        void ExportBitmapAsPNG(Bitmap bitmap, string fileName)
        {
            var sdCardPath = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            var filePath = System.IO.Path.Combine(sdCardPath, fileName);
            var stream = new FileStream(filePath, FileMode.Create);
            bitmap.Compress(Bitmap.CompressFormat.Png, 100, stream);
            stream.Close();
        }
    }
    
    
}