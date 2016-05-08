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
	[Register ("EmailViewController")]
	partial class EmailViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ButtonEmailSubmit { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIWebView EmailWebView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField TextFieldEmailPassword { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField TextFieldStudentEmail { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ButtonEmailSubmit != null) {
				ButtonEmailSubmit.Dispose ();
				ButtonEmailSubmit = null;
			}
			if (EmailWebView != null) {
				EmailWebView.Dispose ();
				EmailWebView = null;
			}
			if (TextFieldEmailPassword != null) {
				TextFieldEmailPassword.Dispose ();
				TextFieldEmailPassword = null;
			}
			if (TextFieldStudentEmail != null) {
				TextFieldStudentEmail.Dispose ();
				TextFieldStudentEmail = null;
			}
		}
	}
}
