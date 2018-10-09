using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;

namespace ContentPageSample.Droid
{
	[Activity(Label = "ContentPageSample", MainLauncher = true)]
	public class MainActivity 
			: 
				// AndroidActivity
				global::Xamarin.Forms.Platform.Android.FormsApplicationActivity // superclass new in 1.3
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			global::OxyPlot.XamarinFormsAndroid.Forms.Init();
			global::Xamarin.Forms.Forms.Init(this, bundle);

			// SetPage(App.GetMainPage());
			LoadApplication (new App ()); // method is new in 1.3

			return;
		}
	}
}

