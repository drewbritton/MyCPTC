using System;
using System.Collections.Generic;
using UIKit;
using Foundation;
using CPTCAppNew;

namespace CPTCAppNew.iOS {
	
	public class EventsTableSource : UITableViewSource {
		string[] TableItems;
		string CellIdentifier = "TableCell";

		MainViewController owner;
		
		public EventsTableSource(string[] items) {
			TableItems = items;    	
		}

		public EventsTableSource(string[] items, MainViewController owner) {
			TableItems = items;
			this.owner = owner;
		}

		public override nint RowsInSection(UITableView tableview, nint section) {
			return TableItems.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath) {
			UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
			cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
			cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			string item = TableItems[indexPath.Row];

			// create a new row (cell) unless one can be recycled
			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);

			cell.TextLabel.Text = item;

			return cell;
		}

		public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath) {
			UIAlertController okAlertController = UIAlertController.Create("Event info: ", TableItems[indexPath.Row], UIAlertControllerStyle.Alert);
			okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

			owner.PresentViewController(okAlertController, true, null);

			tableView.DeselectRow(indexPath, true);
		}

		public override void AccessoryButtonTapped(UITableView tableView, NSIndexPath indexPath) {
			UIAlertController addAlertController = UIAlertController.Create("Add <Event> to calendar?", TableItems[indexPath.Row], UIAlertControllerStyle.ActionSheet);
			addAlertController.AddAction(UIAlertAction.Create("Yes", UIAlertActionStyle.Default, null));
			addAlertController.AddAction(UIAlertAction.Create("No", UIAlertActionStyle.Cancel, null));

			owner.PresentViewController(addAlertController, true, null);

			tableView.DeselectRow(indexPath, true);
		}
	}
}

