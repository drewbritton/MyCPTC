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
    [Register ("CanvasViewController")]
    partial class CanvasViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonCanvasIcon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIWebView CanvasWebView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelEnterCanvasCreds { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelPressCanvasIcon { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonCanvasIcon != null) {
                ButtonCanvasIcon.Dispose ();
                ButtonCanvasIcon = null;
            }

            if (CanvasWebView != null) {
                CanvasWebView.Dispose ();
                CanvasWebView = null;
            }

            if (LabelEnterCanvasCreds != null) {
                LabelEnterCanvasCreds.Dispose ();
                LabelEnterCanvasCreds = null;
            }

            if (LabelPressCanvasIcon != null) {
                LabelPressCanvasIcon.Dispose ();
                LabelPressCanvasIcon = null;
            }
        }
    }
}