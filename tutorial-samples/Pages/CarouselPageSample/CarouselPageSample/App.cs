using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CarouselPageSample
{
	public class App
	{
		public static Page GetMainPage()
		{
			CarouselPage cp =  new CarouselPage();

			cp.Children.Add(new ContentPage() { Title = "ContentPage" });
			cp.Children.Add(new ContentPage() { Title = "ContentPage" });
			cp.Children.Add(new ContentPage() { Title = "ContentPage" });
			
			return cp;
		}
	}
}
