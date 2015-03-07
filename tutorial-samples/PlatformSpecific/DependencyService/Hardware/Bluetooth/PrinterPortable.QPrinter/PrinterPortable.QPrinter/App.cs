using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using PlatformSpecific.DependencyService.FeaturesCapabilities.Bluetooth;

namespace PrinterPortable.QPrinter
{
	public class App
		: Application // superclass new in 1.3
	{
	    public App ()
	    {
	        // The root page of your application
	        MainPage = App.GetMainPage(); // property new in 1.3
	    }
	
		public static Page GetMainPage()
		{
			// KUD Idijote:
			//		upali BT
			//		alo permissions
			IBluetoothPrinterService ibs = null;

			// get Registered service from Platform lib
			ibs = Xamarin.Forms.DependencyService.Get<IBluetoothPrinterService>();

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
