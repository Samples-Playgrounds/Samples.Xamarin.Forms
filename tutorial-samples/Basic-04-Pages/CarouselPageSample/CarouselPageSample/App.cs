using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CarouselPageSample
{
	public class App
		: Application // superclass new in 1.3
	{
	    public App ()
	    {
			CarouselPage cp =  new CarouselPage();

			cp.Children.Add(new ContentPage() { Title = "ContentPage" });
			cp.Children.Add(new ContentPage() { Title = "ContentPage" });
			cp.Children.Add(new ContentPage() { Title = "ContentPage" });

	        // The root page of your application
	        MainPage = 	// property
				cp
				;
				
	        return;
	    }

		//public static Page GetMainPage()
		//{
		//	CarouselPage cp =  new CarouselPage();
        //
		//	cp.Children.Add(new ContentPage() { Title = "ContentPage" });
		//	cp.Children.Add(new ContentPage() { Title = "ContentPage" });
		//	cp.Children.Add(new ContentPage() { Title = "ContentPage" });
		//	
		//	return cp;
		//}
	}
}
