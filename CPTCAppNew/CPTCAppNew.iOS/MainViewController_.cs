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

		public MainViewController(IntPtr handle) : base (handle) {

		}

        // TO DO:
        // make a call from SchoolEventsRepository to populate the mini Events table view
        // on the launch screen.

        public override async void ViewDidLoad() {
            base.ViewDidLoad();

			// sets cell data for the mini Events table view on the launch screen (test data)
			string[] eventsData = {"Jun 20: Finals Week", "Jun 24: Last Day of Spring qtr",
									"Jul 5: First Day of Summer qtr", "Jul 8: Summer BBQ"};

//			EventsTableDataSource source = new EventsTableDataSource();
//			List<SchoolEvents> eventsList = source.PopulateTopEventsTable();
			
			//TableViewEvents is the mini table view at the bottom of the launch screen
//			TableViewEvents.Source = new EventsTableSource(eventsList, this);
//			Add(TableViewEvents);


			// TEST CONNECTION TO WEB API (NOTE: already implemented in SchoolEventsRepository shared class!)
			//HttpClient client = new HttpClient();

			//string apiUrl = "https://cptc.azurewebsites.net/api/events/";
			//var uri = new Uri(apiUrl);

			//var response = client.GetAsync(uri);
			//var responseResult = response.Result;
			//var responseString = responseResult.Content.ReadAsStringAsync();

			////var responseJsonObject = Newtonsoft.Json.Convert
			//List<SchoolEvents> jsonStuff = JsonConvert.DeserializeObject<List<SchoolEvents>>(responseString.Result);

			//foreach (var c in jsonStuff) {
			//	Console.WriteLine(c.Id);
			//	Console.WriteLine(c.Name);
			//	Console.WriteLine(c.Description);
			//	Console.WriteLine(c.PriceOfAdmission);
			//	Console.WriteLine(c.DateOfEvent);
			//}
			// END TEST
        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();
        }
			
    }
}
