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
	[Register ("EventsViewController")]
	partial class EventsViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView EventsTableView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (EventsTableView != null) {
				EventsTableView.Dispose ();
				EventsTableView = null;
			}
		}
	}
}
