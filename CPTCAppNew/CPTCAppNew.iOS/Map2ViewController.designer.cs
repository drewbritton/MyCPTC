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
	[Register ("Map2ViewController")]
	partial class Map2ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView Map2ImageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView MapSHView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MapKit.MKMapView MapViewSH { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Map2ImageView != null) {
				Map2ImageView.Dispose ();
				Map2ImageView = null;
			}
			if (MapSHView != null) {
				MapSHView.Dispose ();
				MapSHView = null;
			}
			if (MapViewSH != null) {
				MapViewSH.Dispose ();
				MapViewSH = null;
			}
		}
	}
}
