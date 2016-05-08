// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CPTCAppNew.iOS
{
	[Register ("MapViewController")]
	partial class MapViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonSHMap { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView MapImageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView MapView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MapKit.MKMapView MapViewLakewood { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ButtonSHMap != null) {
				ButtonSHMap.Dispose ();
				ButtonSHMap = null;
			}
			if (MapImageView != null) {
				MapImageView.Dispose ();
				MapImageView = null;
			}
			if (MapView != null) {
				MapView.Dispose ();
				MapView = null;
			}
			if (MapViewLakewood != null) {
				MapViewLakewood.Dispose ();
				MapViewLakewood = null;
			}
		}
	}
}
