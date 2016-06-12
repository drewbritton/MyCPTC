using System;
using System.Collections;
using System.Linq;

namespace CPTCAppNew {

	/// <summary>
	/// Represents a SchoolEvents object primarily used to
	/// populate table views within the CPTC mobile app. Each
	/// property gets its data from an ASP.NET Web service.
	/// </summary>
	public class SchoolEvents {

		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime DateOfEvent { get; set; }
		public string Description { get; set; }
		public double? PriceOfAdmission { get; set; }

		public override string ToString() {
			return string.Format("SchoolEvents: Id={0}, Name={1}, DateOfEvent={2}, Description={3}, PriceOfAdmission={4}", Id, Name, DateOfEvent, Description, PriceOfAdmission);
		}

	}
}

