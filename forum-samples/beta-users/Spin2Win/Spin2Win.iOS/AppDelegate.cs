using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.QuickUI;

namespace Spin2Win.iOS
{

	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			QuickUI.Init ();

			var application = new Spin2WinApp ();
			window.RootViewController = application.GetMainPage ().GetViewController ();
			window.MakeKeyAndVisible ();

			return true;
		}
	}
}