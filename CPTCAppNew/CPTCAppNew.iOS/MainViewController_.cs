using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CPTCAppNew.iOS {

	partial class MainViewController : UIViewController {

		public MainViewController (IntPtr handle) : base (handle) {

		}

        public override void ViewDidLoad() {
            base.ViewDidLoad();

			ButtonInfo.TranslatesAutoresizingMaskIntoConstraints = false;
        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();
        }

		partial void ButtonInfo_TouchUpInside(UIButton sender) {
			ButtonInfo.TranslatesAutoresizingMaskIntoConstraints = false;
		}
    }
}
