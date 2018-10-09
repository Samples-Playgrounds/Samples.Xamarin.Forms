using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ControlsViews.External
{
	public class App
		: Application // superclass new in 1.3
	{
	    public App ()
	    {
	        // The root page of your application
	        MainPage = 	// property
				new ContentPage
				{
					Content = 
					new Label
					{
						Text = "Hello, Forms !",
						VerticalOptions = LayoutOptions.CenterAndExpand,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
					},
				};

	        return;
	    }

		//public static Page GetMainPage()
		//{
		//	return 
		//		new ContentPage
		//		{
		//			Content = 
		//			new Label
		//			{
		//				Text = "Hello, Forms !",
		//				VerticalOptions = LayoutOptions.CenterAndExpand,
		//				HorizontalOptions = LayoutOptions.CenterAndExpand,
		//			},
		//		};
		//}
	}
}
