using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using global::Xamarin.Forms;

namespace PlatformSpecific.DependencyService
{
	public class App
		: Application // superclass new in 1.3
	{
	    public App ()
	    {
	        // The root page of your application
	        MainPage =	// property in 1.3
				//new PageMain()
				new NavigationPage(new PageMain())
				// PageBluetoothPrinter()
				; 	

	        return;
	    }


		//public static Page GetMainPage()
		//{
		//	return 
		//		new 
		//			PageMain()
		//			// PageBluetoothPrinter()
		//			;
        //
		//}
	}
}
