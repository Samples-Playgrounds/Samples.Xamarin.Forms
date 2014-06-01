using System;
using Newtonsoft.Json;

namespace Tramchester.App.Models
{
	public class Tramstop
	{
		public string Id {
			get;
			set;
		}

		public string Code {
			get;
			set;
		}

		public string Name {
			get;
			set;
		}

		[JsonProperty("lat")]
		public decimal Latitude {
			get;
			set;
		}

		[JsonProperty("lon")]
		public decimal Longitude {
			get;
			set;
		}

		public string Platform {
			get;
			set;
		}
	}
}

