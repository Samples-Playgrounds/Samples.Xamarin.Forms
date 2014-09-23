using System;
using System.Collections.Generic;
using Tramchester.App.Models;
using Tramchester.App.Services;

namespace Tramchester.App.ViewModels
{
	public class JourniesViewModel : BaseViewModel
	{
		ITramsService tramsService;

		List<Journey> journies;
		public List<Journey> Journies {
			get {
				return journies;
			}
			set {
				journies = value;
				if (journies != null && journies.Count > 0) {
					this.RaiseChanged (() => this.Journies);
				}
			}
		}

		public JourniesViewModel (ITramsService tramsService)
		{
			this.tramsService = tramsService;
		}

		public override async void Init(Dictionary<string, object> parameters)
		{
			if(parameters.ContainsKey("RouteTime") &&
				parameters.ContainsKey("FromStop") &&
				parameters.ContainsKey("ToStop")){

				this.Journies = await this.tramsService.GetJournies ((TimeSpan)parameters["RouteTime"], (string)parameters["FromStop"], (string)parameters["ToStop"]);
			}
		}
	}

}

