using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.QuickUI;
using Xamarin.QuickUI.Platform.Android;
using ImapClientAppShared;

namespace ImapClient_Android
{
	[Activity (Label = "ImapClient.Android", MainLauncher = true)]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			QuickUI.Init (this, bundle);

			this.SetPage (ImapClientApp.MainApp.MainPage);
		}
	}
}


