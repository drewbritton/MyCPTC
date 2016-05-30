//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using System.Linq;
//using Newtonsoft.Json;
//using System.Net.Http;
//
//namespace CPTCAppNew {
//	
//	public class EventsRepository : IEventsRepository {
//		
//		public EventsRepository() {
//			
//		}
//
//		public async Task<IEnumerable<Events>> TopEventsAsync() {
//			var client = new HttpClient();
//			client.BaseAddress = new System.Net.Uri("http://cptc.azurewebsites.net/");
//
//
//			var result = await client.GetStringAsync();
//		}
//	}
//
//	public interface IEventsRepository {
//		Task<IEnumerable<Events>> TopEventsAsync();
//	}
//}

