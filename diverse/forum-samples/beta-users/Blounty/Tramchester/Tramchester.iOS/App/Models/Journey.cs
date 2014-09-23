using System;

namespace Tramchester.App.Models
{
	public class Journey
	{
		public string Summary {
			get;
			set;
		}

		public int TotalDuration {
			get;
			set;
		}

		public string ExpectedArrivalTime {
			get;
			set;
		}

		public string FirstDepartureTime {
			get;
			set;
		}

		public string DurationDepartureSummary {
			get {
				return string.Format ("Departing at {0}, duration of {1} minutes", this.FirstDepartureTime, this.TotalDuration);
			 }
		}
	}
}

