using System;
using System.Collections;
using System.Linq;

namespace CPTCAppNew {

	/// <summary>
	/// Represents an Events object primarily used to
	/// populate table views within the CPTC mobile app. Each
	/// property gets its data from an ASP.NET Web service.
	/// </summary>
	public class SchoolEvents {

		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime DateOfEvent { get; set; }
		public string Description { get; set; }
		public double? PriceOfAdmission { get; set; }

	}
}

