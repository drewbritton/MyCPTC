using System;

namespace CPTCAppNew {
	
	public class GetMapImage {

		// coordinates for Lakewood and South Hill campuses
		public const string lakewoodCampusCoords = "47.1760978, -122.4979392";  // latitude, longitude
		public const string southHillCampusCoords = "47.0983727, -122.2849514"; // latitude, longitude
		
		public GetMapImage() {
			
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

