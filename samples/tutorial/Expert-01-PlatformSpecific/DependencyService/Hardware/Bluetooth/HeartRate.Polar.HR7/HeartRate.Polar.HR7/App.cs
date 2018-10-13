using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HeartRate.Polar.HR7
{
	public class App
		: Application // superclass new in 1.3
	{
	    public App ()
	    {

			IBluetoothLowEnergyService ibs = null;

			// get Registered service from Platform lib
			ibs = Xamarin.Forms.DependencyService.Get<IBluetoothLowEnergyService>();


	        // The root page of your application
	        MainPage = App.GetMainPage(); // property new in 1.3
	    }
	
		public static Page GetMainPage()
		{
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
