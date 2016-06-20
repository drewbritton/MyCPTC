using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using CPTCAppNew;

namespace CPTCAppNew {

    /// <summary>
    /// Serves as a connection handler for accessing and consuming Web services via
    /// an HttpClient. Also provides some methods for receiving Events data from
    /// our ASP.NET Web API.
    /// </summary>
    public class SchoolEventsRepository : ISchoolEventsRepository {
        HttpClient client;
        public const string apiUrl = "https://cptc.azurewebsites.net/api/events";

        // general no-arg constructor that instantiates an HttpClient that lasts the
        // duration of the app's lifecycle.
        public SchoolEventsRepository() {
            client = new HttpClient();
            // limit the size of the response to roughly ***kb.
            //client.MaxResponseContentBufferSize = 511999;
        }

        /// <summary>
        /// Invoked when the user pulls down on the table view to refresh it's contents.
        /// </summary>
        /// <returns>An updated List of SchoolEvents.</returns>
        public async Task<List<SchoolEvents>> RefreshDataAsync() {
            try {
                var uri = new Uri(apiUrl);

                var response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode) {
                    var result = await response.Content.ReadAsStringAsync();
                    var jsonResult = JsonConvert.DeserializeObject<List<SchoolEvents>>(result);
                    return jsonResult;
                }

                return null;
            } catch (Exception ex) {
                SchoolEvents exceptionObject = new SchoolEvents();
                exceptionObject.Name = "No new events";
                exceptionObject.Id = -1;
                List<SchoolEvents> errorList = new List<SchoolEvents>();
                errorList.Add(exceptionObject);
                return errorList;
            }
        }

        /// <summary>
        /// Grabs the top three (or nearest three) SchoolEvents from the Web service
        /// </summary>
        /// <returns>A List of the top three SchoolEvents.</returns>
        public async Task<List<SchoolEvents>> TopEventsAsync() {
			var response = await client.GetStringAsync(new Uri(apiUrl));
			var json = JsonConvert.DeserializeObject<List<SchoolEvents>>(response);
			if (json.Count > 3) {
				List<SchoolEvents> topEvents = new List<SchoolEvents>();
				for (int i = 0; i < 3; i++) {
					topEvents.Add(json[i]);
				}
				return topEvents;
			} else {
				return json;
			}
        }

        /// <summary>
        /// Grabs all SchoolEvents from the Web service, mainly for use
        /// in the table view for the Events view controller.
        /// </summary>
        /// <returns>A List of all SchoolEvents.</returns>
        public async Task<List<SchoolEvents>> GetEventsAsync() {
			var response = await client.GetStringAsync(new Uri(apiUrl));
			return JsonConvert.DeserializeObject<List<SchoolEvents>>(response);
        }

    }

//    // TEST CONNECTION TO WEB API (works!)
//    HttpClient client = new HttpClient();

//    string apiUrl = "https://cptc.azurewebsites.net/api/events/";
//    var uri = new Uri(apiUrl);

//    var response = client.GetAsync(uri);
//    var responseResult = response.Result;
//    var responseString = responseResult.Content.ReadAsStringAsync();

//    //var responseJsonObject = Newtonsoft.Json.Convert
//    List<SchoolEvents> jsonStuff = JsonConvert.DeserializeObject<List<SchoolEvents>>(responseString.Result);

//			foreach (var c in jsonStuff) {
//				Console.WriteLine(c.Id);
//				Console.WriteLine(c.Name);
//				Console.WriteLine(c.Description);
//				Console.WriteLine(c.PriceOfAdmission);
//				Console.WriteLine(c.DateOfEvent);
//			}
//// END TEST

public interface ISchoolEventsRepository {
        Task<List<SchoolEvents>> TopEventsAsync();
        Task<List<SchoolEvents>> GetEventsAsync();
    }
}

