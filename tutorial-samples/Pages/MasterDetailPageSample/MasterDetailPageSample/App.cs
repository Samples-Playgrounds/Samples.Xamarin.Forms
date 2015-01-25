using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MasterDetailPageSample
{
	public class App
		: Application // superclass new in 1.3
	{
	    public App ()
	    {
	        // The root page of your application
	        MainPage = 	// property
			new MasterDetailPage
			{
				Master = 
					new ContentPage()
					{
						Content =
							new Label
							{
								Text = "Master",
								VerticalOptions = LayoutOptions.CenterAndExpand,
								HorizontalOptions = LayoutOptions.CenterAndExpand,
							}
					}
				, Detail = 
					new ContentPage()
					{
						Content  = 
							new Label
							{
								Text = "Detail",
								VerticalOptions = LayoutOptions.CenterAndExpand,
								HorizontalOptions = LayoutOptions.CenterAndExpand,
							}
					}
			};

	        return;
	    }

		//public static Page GetMainPage()
		//{
		//	return 
		//	new MasterDetailPage
		//	{
		//		Master = 
		//			new ContentPage()
		//			{
		//				Content =
		//					new Label
		//					{
		//						Text = "Master",
		//						VerticalOptions = LayoutOptions.CenterAndExpand,
		//						HorizontalOptions = LayoutOptions.CenterAndExpand,
		//					}
		//			}
		//		, Detail = 
		//			new ContentPage()
		//			{
		//				Content  = 
		//					new Label
		//					{
		//						Text = "Detail",
		//						VerticalOptions = LayoutOptions.CenterAndExpand,
		//						HorizontalOptions = LayoutOptions.CenterAndExpand,
		//					}
		//			}
		//	};
		//}
	}
}
