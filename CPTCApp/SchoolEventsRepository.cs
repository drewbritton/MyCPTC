//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using System.Linq;
//using Newtonsoft.Json;
//using System.Net.Http;
//
//namespace CPTCAppNew {
//	
//	/// <summary>
//	/// Serves as a connection handler for accessing and consuming Web services via
//	/// an HttpClient. Also provides some methods for receiving Events data from
//	/// our ASP.NET Web API.
//	/// </summary>
//	public class SchoolEventsRepository {   // NEED TO CREATE AN INTERFACE FOR THIS CLASS!
//
//		// allow this instance of HttpClient to remain for entire "cycle"
//		HttpClient client;
//
//		public SchoolEventsRepository() {
//			client = new HttpClient();
//			// limit the size of the API response to 256kb
//			client.MaxResponseContentBufferSize = 255999;
//
//		}
//
//		public async Task<IEnumerable<SchoolEvents>> RefreshDataAsync() {
//			string apiUrl = "http://cptc.azurewebsites.net/api/events/";  // end of URL missing?
//			var uri = new Uri(apiUrl);
//
//			var response = await client.GetAsync(uri);
//			if (response.IsSuccessStatusCode) {
//				var content = await response.Content.ReadAsStringAsync();
//				Items = JsonConvert.DeserializeObject<IEnumerable<SchoolEvents>>(content);
//			}
//		}
//
//		public async Task<List<SchoolEvents>> DownloadEventsAsync() {
//			string url = "http://cptc.azurewebsites.net";
//
//			using (HttpClient eventsClient = new HttpClient())
//			using (HttpResponseMessage response = await client.GetAsync(url))
//			using (HttpContent content = response.Content) {
//				string result = await content.ReadAsStringAsync();
//
//				if (result != null && result.Length >= 20) {
//					Console.WriteLine(result.Substring(0, 40) + "\n");
//				}
//			}
//		}
//	}
//
//	// INTERFACE NEEDS ADDITIONAL CRAP
//	public interface ISchoolEventsRepository {
//		Task<IEnumerable<SchoolEvents>> GetSchoolEventsAsync();
//	}
//}

