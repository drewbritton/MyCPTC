using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreLocation;
using MapKit;

namespace CPTCAppNew.iOS {

	partial class Map2ViewController : UIViewController {

		public Map2ViewController(IntPtr handle) : base(handle) {

		}

        // default method to handle actions AFTER the viewcontroller and it's view are loaded
        // (put all properties/settings/manipulations of iOS view controls in this method)
        public override void ViewDidLoad() {
            base.ViewDidLoad();

            // adjust the map view to fit in the device's viewport
            MapViewSH.AutoresizingMask = UIViewAutoresizing.FlexibleDimensions;
            View.AddSubview(MapViewSH);

            // coordinates for CPTC Lakewood campus
            CLLocationCoordinate2D coords = new CLLocationCoordinate2D(47.0983727, -122.2849514);  // latitude, longitude

            // the area to display (in miles)
            MKCoordinateSpan viewSpan = new MKCoordinateSpan(MilesToLatitudeDegrees(1), MilesToLongitudeDegrees(1, coords.Latitude));

            // set Region
            MapViewSH.Region = new MKCoordinateRegion(coords, viewSpan);

        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();

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
