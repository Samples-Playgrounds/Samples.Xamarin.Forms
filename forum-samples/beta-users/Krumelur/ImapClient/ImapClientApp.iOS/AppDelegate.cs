using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.QuickUI;
using ImapClientAppShared;
using Xplat_Core;

namespace ImapClientApp_iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		public UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			this.window = new UIWindow (UIScreen.MainScreen.Bounds);

			QuickUI.Init ();

			var quickUiApp = ImapClientApp.MainApp;
			// Plug in the iOS version of the QR reader.
			ServiceContainer.Register<IQrService>(() => new ZXingQrService {
				Page = ((NavigationPage)quickUiApp.MainPage).Current
			});

			window.RootViewController = quickUiApp.MainPage.GetViewController ();

			window.MakeKeyAndVisible ();

			return true;
		}
	}
}

