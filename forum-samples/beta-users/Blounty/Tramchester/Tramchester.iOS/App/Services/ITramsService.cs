using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Tramchester.App.Models;

namespace Tramchester.App.Services
{
	public interface ITramsService
	{
		Task<List<Tramstop>> GetNearbyTramstops(double latitude, double longitude);

		Task<List<Journey>> GetJournies (TimeSpan departureTime, string startId, string endId);
	}
}

