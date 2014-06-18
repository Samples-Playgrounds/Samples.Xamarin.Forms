using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedPageSample
{
	public class App
	{
		public static Page GetMainPage()
		{
			TabbedPage tp =  new TabbedPage();

			tp.Children.Add(new ContentPage(){Title = "ContentPage"});
			tp.Children.Add(new NavigationPage() { Title = "NavigationPage" });
			tp.Children.Add(new CarouselPage() { Title = "CarouselPage" });

			return tp;
		}
	}
}
