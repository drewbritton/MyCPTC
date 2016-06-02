using System;
using System.Collections.Generic;
using SQLite;
using CPTCAppNew;

namespace CPTCApp {
	
	public class SchoolEventsDb {
		
		public SchoolEventsDb(string path) {
			createDatabase(path);
			var listData = GetSchoolEvents();


			foreach (var c in listData) {
				SchoolEventsTable tableData = new SchoolEventsTable();
				tableData.Id = c.Id;
				tableData.Name = c.Name;
				tableData.Description = c.Description;
				tableData.DateOfEvent = c.DateOfEvent;
				tableData.PriceOfAdmission = c.PriceOfAdmission;

				insertUpdateData(tableData, path);
			}

			//insertUpdateData(listData, path);
		}

		public List<SchoolEvents> GetSchoolEvents() {
			var returnedEvents = new SchoolEventsRepository();
			return returnedEvents.GetEventsAsync();
		}

		public string createDatabase(string path) {
			try {
				var connection = new SQLiteAsyncConnection(path);
					connection.CreateTableAsync<SchoolEventsTable>();
					return "Database created";
				
				} catch (SQLiteException ex) {
					return ex.Message;
				}
		}

		public string insertUpdateData(SchoolEventsTable data, string path) {
			try {
				var db = new SQLiteAsyncConnection(path);
				if (db.InsertAsync(data) != 0)
					db.UpdateAsync(data);

				return "Single data file inserted or updated";

			} catch (SQLiteException ex) {
				return ex.Message;
			}
		}

		private int findNumberRecords(string path) {
			try {
				var db = new SQLiteAsyncConnection(path);
				// counts all records in the database
				var count = db.ExecuteScalarAsync<int>("SELECT Count(*) FROM SchoolEventsTable");

				return count;

			} catch (SQLiteException ex) {
				return -1;
			}
		}
	}
}

