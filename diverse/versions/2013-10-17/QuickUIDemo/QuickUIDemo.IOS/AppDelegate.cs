using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.QuickUI;

namespace QuickUIDemo.IOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			QuickUI.Init ();
			window.RootViewController = DemoApp.GetMainPage ().GetViewController ();

			window.MakeKeyAndVisible ();

			return true;
		}
	}
}

