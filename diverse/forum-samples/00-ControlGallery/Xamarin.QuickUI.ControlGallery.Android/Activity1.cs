using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.QuickUI.Platform.Android;

namespace Xamarin.QuickUI.ControlGallery.Android
{
	[Activity (Label = "Control Gallery", 
	           Icon = "@drawable/icon",
	           MainLauncher = true, 
	           HardwareAccelerated = true, 
	           ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class Activity1 : AndroidActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			QuickUI.Init (this, bundle);
			SetPage (Controls.QuickUIApp.GetQuickUIApp ());
		}
		
		public override void OnConfigurationChanged (global::Android.Content.Res.Configuration newConfig)
		{
			// we're good
			base.OnConfigurationChanged (newConfig);
		}
		
		protected override void OnDestroy ()
		{
			base.OnDestroy ();
		}
	}
}

