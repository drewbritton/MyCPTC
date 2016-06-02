using System;
using System.Collections.Generic;
using SQLite;
using CPTCAppNew;

namespace CPTCApp {

	/// <summary>
	/// Provides a SQLite database comprised of a SchoolEventsTable
	/// List that contains all events from our Events Web API. Also
	/// allows Insert/Update commands and Select count(*) queries.
	/// </summary>
	public class SchoolEventsDb {

		/// <summary>
		/// Initializes a new instance of the <see cref="CPTCApp.SchoolEventsDb"/> class.
		/// </summary>
		/// <param name="path">The path of the local database within the iOS/Android
		/// filesystem.</param>
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
		}

		/// <summary>
		/// Makes a call to "GetEventsAsync()" from the SchoolEventsRepository
		/// class.
		/// </summary>
		/// <returns>A List of SchoolEvents objects.</returns>
		public List<SchoolEvents> GetSchoolEvents() {
			var returnedEvents = new SchoolEventsRepository();
			return returnedEvents.GetEventsAsync();
		}

		/// <summary>
		/// Constructs a SQLite database locally.
		/// </summary>
		/// <returns>A string that signifies that the database was
		/// created successfully.</returns>
		/// <param name="path">The path of the local database.</param>
		public string createDatabase(string path) {
			try {
				var connection = new SQLiteAsyncConnection(path);
					connection.CreateTableAsync<SchoolEventsTable>();
					return "Database created";
				
				} catch (SQLiteException ex) {
					return ex.Message;
				}
		}

		/// <summary>
		/// Allows Insert and Update commands to the SQLite local database.
		/// </summary>
		/// <returns>Whether or not the data was successfully inserted/updated.</returns>
		/// <param name="data">The SchoolEventsTable data object.</param>
		/// <param name="path">The path of the local database.</param>
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

		/// <summary>
		/// Reports the number (count) of all database entries.
		/// </summary>
		/// <returns>The number of records.</returns>
		/// <param name="path">The path of the local database.</param>
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

