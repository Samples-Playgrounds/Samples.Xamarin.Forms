using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Images
{
	public class App
		: Application // superclass new in 1.3
	{
		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {...}; // property new in 1.3
		}

		public static Page GetMainPage()
		{
			return new ContentPage
			{
				Content = new Label
				{
					Text = "Hello, Forms !",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}
	}
}
