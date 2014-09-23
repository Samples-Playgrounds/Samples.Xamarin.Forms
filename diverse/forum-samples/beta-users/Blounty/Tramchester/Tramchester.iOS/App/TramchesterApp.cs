using System;
using Xamarin.QuickUI;
using Tramchester.App.Views;
using XPlatUtils;
using Tramchester.App.Services;
using Tramchester.App.ViewModels;

namespace Tramchester.App
{
	public class TramchesterApp
	{
		public static void Init(Action platformSpecificInit)
		{
			ServiceContainer.Register<ITramsService> (() => new TramsService ());
			ServiceContainer.Register<HomeViewModel> (() => new HomeViewModel ());
			ServiceContainer.Register<RoutePlannerViewModel> (() => new RoutePlannerViewModel ());
			ServiceContainer.Register<TramstopsViewModel> (() => new TramstopsViewModel(ServiceContainer.Resolve<ITramsService>()));
			ServiceContainer.Register<JourniesViewModel> (() => new JourniesViewModel(ServiceContainer.Resolve<ITramsService>()));

			platformSpecificInit ();

		}

		public static Page GetMainAppUI()
		{
			var homeView = new HomeView ();
			var homeViewModel = new HomeViewModel ();
			homeViewModel.Navigation = homeView.Navigation;
			homeView.BindingContext = homeViewModel;
			return new NavigationPage (homeView);
		}
	}
}

