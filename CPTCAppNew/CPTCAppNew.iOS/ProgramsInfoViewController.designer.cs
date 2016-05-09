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
	[Register ("ProgramsInfoViewController")]
	partial class ProgramsInfoViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITabBarItem ProgramsTab { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView ProgramsTableView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ProgramsTab != null) {
				ProgramsTab.Dispose ();
				ProgramsTab = null;
			}
			if (ProgramsTableView != null) {
				ProgramsTableView.Dispose ();
				ProgramsTableView = null;
			}
		}
	}
}
