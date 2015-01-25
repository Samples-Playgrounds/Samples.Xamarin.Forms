using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace ControlsViewsMap
{
	public class App
		: Application // superclass new in 1.3
	{
	    public App ()
	    {
	        // The root page of your application
	        MainPage = 	// property
				new MapPage(); 	

	        return;
	    }

		//public static Page GetMainPage()
		//{
		//	return new MapPage();
		//}
	}

	public class MapPage : ContentPage
	{
		public MapPage() 
		{
			var map = 
				new Map
					(
						MapSpan.FromCenterAndRadius
							(							
								new Position(37,-122)
							, Distance.FromMiles(0.3)
							)
					) 
				{
					IsShowingUser = true,
					HeightRequest = 100,
					WidthRequest = 960,
					VerticalOptions = LayoutOptions.FillAndExpand
				};
				
				var stack = new StackLayout { Spacing = 0 };
				stack.Children.Add(map);
				Content = stack;
				
				return;
		}
	}
}
