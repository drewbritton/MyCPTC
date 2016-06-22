using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CPTCAppNew.iOS {
	
	partial class CanvasViewController : UIViewController {
		
		public CanvasViewController(IntPtr handle) : base(handle) {
			
		}

		public override void ViewDidLoad() {
			base.ViewDidLoad();

			// the URL for CPTC's Canvas login page
			var canvasUrl = "https://cptc.instructure.com/login/canvas";

			// load the canvasUrl in a NSUrlRequest (needed for iOS 9)
			CanvasWebView.LoadRequest(new NSUrlRequest(new NSUrl(canvasUrl)));

			// scale down the page so that it fits in the device's viewport
			CanvasWebView.ScalesPageToFit = true;
		}

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();
        }
    }
}
