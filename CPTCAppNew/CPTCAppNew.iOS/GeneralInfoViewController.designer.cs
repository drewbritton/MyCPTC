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
	[Register ("GeneralInfoViewController")]
	partial class GeneralInfoViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITabBarItem GeneralInfoTab { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView GeneralInfoTableView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (GeneralInfoTab != null) {
				GeneralInfoTab.Dispose ();
				GeneralInfoTab = null;
			}
			if (GeneralInfoTableView != null) {
				GeneralInfoTableView.Dispose ();
				GeneralInfoTableView = null;
			}
		}
	}
}
