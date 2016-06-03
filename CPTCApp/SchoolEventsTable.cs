using System;
using SQLite;
using CPTCAppNew;

namespace CPTCApp {
	
	public class SchoolEventsTable {

		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime DateOfEvent { get; set; }  // can't be used in SQLite
		public string Date { get; set; }  // use this in SQLite db
		public string Description { get; set; }
		public double? PriceOfAdmission { get; set; }

		public override string ToString() {
			return string.Format("SchoolEvents: Id={0}, Name={1}, DateOfEvent={2}, Description={3}, PriceOfAdmission={4}", Id, Name, DateOfEvent, Description, PriceOfAdmission);
		}
	}
}

