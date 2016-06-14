using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CPTCAppNew;

using Newtonsoft.Json;

namespace CPTCAppNew {
	
	public class EventsTableDataSource {

		//List<SchoolEvents> tableItems;

//		public EventsTableDataSource() {
//			
//		}
//		
//		public EventsTableDataSource(List<SchoolEvents> items) {
//			tableItems = items;
//		}

		// TODO: these methods might not need to be marked as async...
		// can't use await when returning results.GetEventsAsync().result
		public List<SchoolEvents> PopulateTable() {
			SchoolEventsRepository results = new SchoolEventsRepository();
			var eventsList = results.GetEventsAsync();
			return eventsList.Result;
		}

		public List<SchoolEvents> PopulateTopEventsTable() {
			SchoolEventsRepository results = new SchoolEventsRepository();
			var eventsList = results.TopEventsAsync();
			return eventsList.Result;
		}

	}
}

