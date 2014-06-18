using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MasterDetailPageSample
{
	public class App
	{
		public static Page GetMainPage()
		{
			return new MasterDetailPage
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
		}
	}
}
