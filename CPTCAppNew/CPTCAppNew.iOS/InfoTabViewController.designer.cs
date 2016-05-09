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
	[Register ("InfoTabViewController")]
	partial class InfoTabViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITabBar InfoTabBar { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (InfoTabBar != null) {
				InfoTabBar.Dispose ();
				InfoTabBar = null;
			}
		}
	}
}
