using Foundation;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading.Tasks;
using UIKit;

using CPTCAppNew;

namespace CPTCAppNew.iOS {
	
	partial class EventsViewController : UITableViewController {
		
		public EventsViewController (IntPtr handle) : base (handle) {
			
		}

		public override void ViewDidLoad() {
			base.ViewDidLoad();
			EventsTableView = new UITableView(View.Bounds);
			EventsTableDataSource source = new EventsTableDataSource();
			List<SchoolEvents> eventsList = source.PopulateTable();

			EventsTableView.Source = new EventsTableSource(eventsList);
			Add(EventsTableView);
		}
			
	}
}
