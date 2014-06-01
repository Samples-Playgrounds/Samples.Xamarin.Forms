using System;

using Android.App;
using Android.Widget;
using Android.OS;
using Xamarin.QuickUI;
using Xamarin.QuickUI.Platform.Android;

namespace QuickUIExample.Android
{
	[Activity(Label = "QuickUIExample.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class QuickUIActivity : AndroidActivity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate(bundle);

			QuickUI.Init(this, bundle);
			var page = new ContentPage
			{
				Content = new Label
				{
					Text = "Hello World!",
					VerticalOptions = LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center
				}
			};
			SetPage (page);
		}
	}
}

