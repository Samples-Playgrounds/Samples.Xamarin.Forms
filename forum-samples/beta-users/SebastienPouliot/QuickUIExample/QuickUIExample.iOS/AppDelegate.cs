using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.QuickUI;

namespace QuickUIExample.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow(UIScreen.MainScreen.Bounds);

			QuickUI.Init ();
			var page = new ContentPage {
				Content = new Label {
					Text = "Hello World!",
					VerticalOptions = LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center
				}
			};

			window.RootViewController = page.GetViewController ();

			window.MakeKeyAndVisible();

			return true;
		}
	}
}

