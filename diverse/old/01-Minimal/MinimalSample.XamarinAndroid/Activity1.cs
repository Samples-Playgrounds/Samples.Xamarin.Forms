using System;

using Android.App;
using Android.OS;

using Xamarin.QuickUI;
using Xamarin.QuickUI.Platform.Android;

namespace MinimalSample.XamarinAndroid
{
	[Activity(Label = "MinimalSample.XamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
	public class Activity1 
	: 
	//Activity
	AndroidActivity
	{
		int count = 1;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			QuickUI.Init(this, bundle);

			SetPage(new MainQuickUIPage());
		}
	}



	public class MainQuickUIPage : ContentPage
	{
		public MainQuickUIPage()
		{
			Content = new Button
			{
				Text = "Welcome to QuickUI",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
		}
	}
}

