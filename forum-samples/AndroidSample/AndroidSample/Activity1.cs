using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.OS;
using Xamarin.QuickUI;
using Xamarin.QuickUI.Platform.Android;

namespace AndroidSample
{
	[Activity (Label = "AndroidSample", MainLauncher = true, Icon = "@drawable/icon")]
	public class Activity1 : AndroidActivity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			QuickUI.Init (this, bundle);

			SetPage (new MainQuickUIPage ());
		}
	}

	public class MainQuickUIPage : ContentPage
	{
		public MainQuickUIPage ()
		{
			Content = new Button {
				Text = "Welcome to QuickUI",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
		}
	}
}

