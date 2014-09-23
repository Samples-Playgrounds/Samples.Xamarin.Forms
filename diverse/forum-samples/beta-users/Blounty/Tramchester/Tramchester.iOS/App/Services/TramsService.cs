using System;
using System.Collections.Generic;
using Tramchester.App.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Tramchester.App.Services
{
	public class TramsService : ITramsService
	{
		public async Task<List<Tramstop>> GetNearbyTramstops(double latitude, double longitude)
		{
			var client = new HttpClient ();
			var response = await client.GetAsync(
				string.Format("http://www.tramchester.co.uk/service/transportStop/{0}/{1}", latitude, longitude));

			var tramStopJson = await response.Content.ReadAsStringAsync ();

			var tramstops = (List<Tramstop>)JsonConvert.DeserializeObject (tramStopJson, typeof(List<Tramstop>));

			return tramstops;
		}

		public async Task<List<Journey>> GetJournies (TimeSpan routeTime, string startId, string endId)
		{
			var client = new HttpClient ();
			var routeTimeString = string.Format ("{0}:{1}:{2}", routeTime.Hours, routeTime.Minutes, routeTime.Seconds);
			var response = await client.GetAsync(
				string.Format("http://www.tramchester.co.uk/service/journey?departureTime={0}&end={1}&start={2}", routeTimeString, endId, startId));

			var journeyStopsJson = await response.Content.ReadAsStringAsync ();

			var journeyJson = JObject.Parse (journeyStopsJson) ["journeys"].ToString();

			var journies = (List<Journey>)JsonConvert.DeserializeObject (journeyJson, typeof(List<Journey>));

			return journies;
		}
	}
}

