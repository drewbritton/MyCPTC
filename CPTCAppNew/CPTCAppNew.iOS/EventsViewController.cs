using Foundation;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading.Tasks;
using UIKit;

using CPTCAppNew;

namespace CPTCAppNew.iOS {
	
	partial class EventsViewController : UITableViewController {
		
		public EventsViewController(IntPtr handle) : base(handle) {
			
		}

		public async override void ViewDidLoad() {
			base.ViewDidLoad();
			EventsTableView = new UITableView(View.Bounds);

			SchoolEventsRepository source = new SchoolEventsRepository();
			List<SchoolEvents> eventsList = await source.GetEventsAsync();
			string[] eventsArray = new string[eventsList.Count];

			for (int i = 0; i < eventsList.Count; i++) {
				DateTime dt = Convert.ToDateTime(eventsArray[i]);
				eventsArray[i] = dt.Month + "/" + dt.Day + "   " + eventsList[i].Name;
			}

			EventsTableView.Source = new EventsTableSource(eventsArray);
			Add(EventsTableView);
		}
			
	}
}
