using System;
using System.Windows.Input;
using Xamarin.QuickUI;

namespace Tramchester.App.ViewModels
{
	public class HomeViewModel : BaseViewModel
	{
		ICommand showRoutePlannerCommand;
		public ICommand ShowRoutePlannerCommand {
			get {
				return showRoutePlannerCommand;
			}
			set {
				showRoutePlannerCommand = value;
			}
		}

		public HomeViewModel ()
		{
			this.ShowRoutePlannerCommand = new Command (this.ShowRoutePlanner);
		}

		private void ShowRoutePlanner()
		{
			this.Navigate<RoutePlannerViewModel>();
		}
	}
}

