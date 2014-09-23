using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.QuickUI;
using Xamarin.QuickUI.Platform.Android;

namespace Spin2Win.Android
{
	[Activity (Label = "Spin2Win.Android", 
		MainLauncher = true,
		Icon = "@drawable/icon",
		HardwareAccelerated = true,
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class Activity1 : AndroidActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			try {
				QuickUI.Init (this, bundle);
			} catch (Exception ex) {
				Console.WriteLine (ex.Message);
			}

			var app = new Spin2WinApp ();
			SetPage (app.GetMainPage ());
		}
	}
}

