// ===========================================
// MyCPTC Mobile App   version 1.0a
// Created by: Chris Rocks, Drew Britton, Kevin Osenton
// Internship, Spring 2016
//
// Owned by Clover Park Technical College
// ===========================================
//
using System;
using UIKit;

namespace CPTCAppNew.iOS {
	
	public class EventsTableSource : UITableViewSource {
		string[] TableItems;
		string CellIdentifier = "TableCell";
		
		public EventsTableSource(string[] items) {
			TableItems = items;	    	
		}

		public override nint RowsInSection(UITableView tableview, nint section) {
			return TableItems.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath) {
			UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
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

			tableView.DeselectRow(indexPath, true);
		}
	}
}

