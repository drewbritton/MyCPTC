using Foundation;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading.Tasks;
using UIKit;
using System.Net.Http;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using CPTCAppNew;

namespace CPTCAppNew.iOS {

	public partial class MainViewController : UIViewController {

		public MainViewController(IntPtr handle) : base(handle) {

		}

        public override async void ViewDidLoad() {
            base.ViewDidLoad();

			// declare a new LoadingOverlay object
			LoadingOverlay loadingOverlay;
			var bounds = UIScreen.MainScreen.Bounds;

			// show the loading overlay screen on the UI thread using the correct orientation (portrait)
			loadingOverlay = new LoadingOverlay(bounds);
			View.Add(loadingOverlay);

			SchoolEventsRepository source = new SchoolEventsRepository();
			List<SchoolEvents> eventsList = await source.TopEventsAsync();
			string[] topEvents = new string[eventsList.Count];

			for (int i = 0; i < eventsList.Count; i++) {
				DateTime dt = Convert.ToDateTime(topEvents[i]);
				topEvents[i] = dt.Month + "/" + dt.Day + "   " + eventsList[i].Name;
			}
			
			//TableViewEvents is the mini table view at the bottom of the launch screen
			TableViewEvents.Source = new EventsTableSource(topEvents);
			Add(TableViewEvents);

			// stop displaying current LoadingOverlay
			loadingOverlay.Hide();

        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();
        }
			
    }
}
