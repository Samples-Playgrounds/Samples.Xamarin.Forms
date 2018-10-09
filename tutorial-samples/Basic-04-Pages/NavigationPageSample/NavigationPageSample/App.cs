using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NavigationPageSample
{
	public class App
		: Application // superclass new in 1.3
	{
	    public App ()
	    {
	        // The root page of your application
	        MainPage = 	// property
				new NavigationPage(new PageContentUsedByNavigationPage()); 	

	        return;
	    }
		
		//public static Page GetMainPage()
		//{
		//	return new NavigationPage
		//	{
		//	};
		//}
	}
}
