using CoreLocation;
using Foundation;
using MapKit;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Net;
using System.Drawing;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Text;


namespace CPTCAppNew.iOS {

	partial class MapViewController : UIViewController {

		public MapViewController (IntPtr handle) : base (handle) {

		}

        // default method to handle actions AFTER the viewcontroller and it's view are loaded
        // (put all properties/settings/manipulations of iOS view controls in this method)
        public override void ViewDidLoad() {
            base.ViewDidLoad();

            // adjust the map view to fit in the device's viewport
            //MapViewLakewood.AutoresizingMask = UIViewAutoresizing.FlexibleDimensions;
            //View.AddSubview(MapViewLakewood);

			//Adds campus map from image url
			String url = "http://www.cptc.edu/sites/default/files/files/Lakewood%20Campus%20Map.jpeg";

			MapImageView.Image = FromUrl (url);
			View.AddSubview (MapImageView);


			/*
            // coordinates for CPTC Lakewood campus
            CLLocationCoordinate2D coords = new CLLocationCoordinate2D(47.1760978, -122.4979392);  // latitude, longitude

            // the area to display (in miles)
            MKCoordinateSpan viewSpan = new MKCoordinateSpan(MilesToLatitudeDegrees(1), MilesToLongitudeDegrees(1, coords.Latitude));

            // set Region
            MapViewLakewood.Region = new MKCoordinateRegion(coords, viewSpan);
			*/

        }

        // default method to deal with low RAM issues
        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();

        }

		public static UIImage FromUrl (string uri)
		{
			using (NSUrl url = new NSUrl (uri))
			using (NSData data = NSData.FromUrl (url)) {
				if (data == null) {
					return new UIImage ();
				}
				return UIImage.LoadFromData (data);
			}
		}

        // calculates the latitude coord(s) in miles
        public double MilesToLatitudeDegrees(double miles) {
            double earthRadius = 3960.00;  // miles
            double radiansToDegrees = 180.0 / Math.PI;
            return (miles / earthRadius) * radiansToDegrees;
        }

        // calculates the longitude coord(s) in miles
        public double MilesToLongitudeDegrees(double miles, double atLatitude) {
            double earthRadius = 3960.00;  // miles
            double degreesToRadians = Math.PI / 180.0;
            double radiansToDegrees = 180.0 / Math.PI;
            // derive the earth's radius at that point in latitude
            double radiusAtLatitude = earthRadius * Math.Cos(atLatitude * degreesToRadians);
            return (miles / radiusAtLatitude) * radiansToDegrees;
        }
    }
}
