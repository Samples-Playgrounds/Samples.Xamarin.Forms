using System;
using Xamarin.Geolocation;
using System.Threading.Tasks;
using System.Net.Http;
using Tramchester.App.Services;
using Tramchester.App.Models;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.QuickUI;

namespace Tramchester.App.ViewModels
{
	public class RoutePlannerViewModel : BaseViewModel
	{
		Tramstop fromTramstop;
		public Tramstop FromTramstop {
			get {
				return fromTramstop;
			}
			set {
				fromTramstop = value;
				this.RaiseChanged (() => this.FromTramstop);
				this.RaiseChanged (() => this.CanGetJournies);
			}
		}

		Tramstop toTramstop;
		public Tramstop ToTramstop {
			get {
				return toTramstop;
			}
			set {
				toTramstop = value;
				this.RaiseChanged (() => this.ToTramstop);
				this.RaiseChanged (() => this.CanGetJournies);
			}
		}

		TimeSpan routeTime;
		public TimeSpan RouteTime {
			get {
				return routeTime;
			}
			set {
				routeTime = value;
				this.RaiseChanged (() => this.RouteTime);
				this.RaiseChanged (() => this.CanGetJournies);
			}
		}

		public bool CanGetJournies {
			get {
				return (this.ToTramstop != null 
					&& this.FromTramstop != null);
			}
		}

		ICommand getJourniesCommand;
		public ICommand GetJourniesCommand {
			get {
				return getJourniesCommand;
			}
			set {
				getJourniesCommand = value;
			}
		}

		ICommand getFromTramstopsCommand;
		public ICommand GetFromTramstopsCommand {
			get {
				return getFromTramstopsCommand;
			}
			set {
				getFromTramstopsCommand = value;
			}
		}

		ICommand getToTramstopsCommand;
		public ICommand GetToTramstopsCommand {
			get {
				return getToTramstopsCommand;
			}
			set {
				getToTramstopsCommand = value;
			}
		}

		public RoutePlannerViewModel ()
		{
			this.RouteTime = DateTime.Now.TimeOfDay;
			this.GetJourniesCommand = new Command (this.GetJournies);
			this.GetFromTramstopsCommand = new Command (this.GetFromTramstops);
			this.GetToTramstopsCommand = new Command (this.GetToTramstops);
		}

		private void GetJournies()
		{
			this.Navigate<JourniesViewModel>(new Dictionary<string, object> { {"RouteTime", this.RouteTime}, {"FromStop", this.FromTramstop.Id}, {"ToStop", this.ToTramstop.Id}});
		}

		private void GetFromTramstops(){

			MessagingCenter.Subscribe<Tramstop> (this, "TramstopSelected", this.FromTramstopSelected);
			this.Navigate<TramstopsViewModel> ();
		}

		private void FromTramstopSelected(Tramstop tramstop)
		{
			this.FromTramstop = tramstop;

			this.RunOnMainThread (() => 
				{
					this.NavigateBack();
					MessagingCenter.Unsubscribe<Tramstop> (this, "TramstopSelected");
				});
		}

		private void GetToTramstops(){

			MessagingCenter.Subscribe<Tramstop> (this, "TramstopSelected", this.ToTramstopSelected);
			this.Navigate<TramstopsViewModel> ();
		}

		private void ToTramstopSelected(Tramstop tramstop)
		{
			this.ToTramstop = tramstop;

			this.RunOnMainThread (() => 
				{
					this.NavigateBack();
					MessagingCenter.Unsubscribe<Tramstop> (this, "TramstopSelected");
				});
		}
	}
}

