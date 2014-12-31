using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ControlsViewsExtras
{
	public class App
	{
		public static Page GetMainPage()
		{
			return new ContentPage
			{
				Content = new OxyPlot.XamarinForms.PlotView
				{
					Model = new OxyPlot.PlotModel { Title = "Hello Xamarin.Forms" },
					VerticalOptions = LayoutOptions.Fill,
					HorizontalOptions = LayoutOptions.Fill,
				},
			};
		}
	}
}
