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
	[Register ("InfoTableViewController")]
	partial class InfoTableViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		InfoTableViewController dataSource { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		InfoTableViewController @delegate { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		InfoTableViewController InfoTableView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (dataSource != null) {
				dataSource.Dispose ();
				dataSource = null;
			}
			if (@delegate != null) {
				@delegate.Dispose ();
				@delegate = null;
			}
			if (InfoTableView != null) {
				InfoTableView.Dispose ();
				InfoTableView = null;
			}
		}
	}
}
