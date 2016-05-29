using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CPTCAppNew.iOS {

	public partial class MainViewController : UIViewController {

		public MainViewController(IntPtr handle) : base (handle) {

		}

        public override void ViewDidLoad() {
            base.ViewDidLoad();

			// sets cell data for the mini Events table view on the launch screen
			string[] eventsData = {"Jun 20: Finals Week", "Jun 24: Last Day of Spring qtr",
									"Jul 5: First Day of Summer qtr", "Jul 8: Summer BBQ"};
			
			// TableViewEvents is the table view at the bottom of the launch screen
			TableViewEvents.Source = new EventsTableSource(eventsData, this);
			Add(TableViewEvents);

        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();
        }
			
    }
}
