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
    [Register ("LaunchViewController")]
    partial class LaunchViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageLaunchScreen { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imageLaunchScreen != null) {
                imageLaunchScreen.Dispose ();
                imageLaunchScreen = null;
            }
        }
    }
}