using System;
using Tramchester.App.ViewModels;
using Tramchester.App.Models;
using System.Collections.Generic;
using Tramchester.App.Services;
using Xamarin.Geolocation;
using System.Threading.Tasks;

namespace Tramchester.App.ViewModels
{
	public class TramstopsViewModel : BaseViewModel
	{
		private ITramsService tramsService;

		List<Tramstop> tramstops;
		public List<Tramstop> Tramstops {
			get {
				return tramstops;
			}
			set {
				tramstops = value;
				this.RaiseChanged (() => this.Tramstops);
			}
		}

		public TramstopsViewModel (ITramsService tramsService)
		{
			this.tramsService = tramsService;

			var locator = new Geolocator { DesiredAccuracy = 50 };
			locator.GetPositionAsync (timeout: 10000).ContinueWith (t => {
				this.GetNearbyTramStops(t.Result.Latitude, t.Result.Longitude);
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		private async void GetNearbyTramStops(double latitude, double longitude)
		{
			this.Tramstops = await this.tramsService.GetNearbyTramstops (latitude, longitude);
		}
	}
}

