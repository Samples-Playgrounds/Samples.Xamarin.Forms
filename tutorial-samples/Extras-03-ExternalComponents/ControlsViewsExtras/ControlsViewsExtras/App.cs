using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using OxyPlot;
using OxyPlot.Series;

namespace ControlsViewsExtras
{
	public class App 
		: Application
	{
		public App()
		{
			var model = new PlotModel { Title = "World population by continent" };

	        var ps = new PieSeries
	        {
	            StrokeThickness = 2.0,
	            InsideLabelPosition = 0.8,
	            AngleSpan = 360,
	            StartAngle = 0
	        };

	        // http://www.nationsonline.org/oneworld/world_population.htm
	        // http://en.wikipedia.org/wiki/Continent
	        ps.Slices.Add(new PieSlice("Africa", 1030) { IsExploded = true });
	        ps.Slices.Add(new PieSlice("Americas", 929) { IsExploded = true });
	        ps.Slices.Add(new PieSlice("Asia", 4157));
	        ps.Slices.Add(new PieSlice("Europe", 739) { IsExploded = true });
	        ps.Slices.Add(new PieSlice("Oceania", 35) { IsExploded = true });

	        model.Series.Add(ps);




			// https://github.com/conceptdev/xamarin-forms-samples/tree/master/OxyPlotDemo
			var Points = new List<DataPoint>
			{
			new DataPoint(0, 4),
			new DataPoint(10, 13),
			new DataPoint(20, 15),
			new DataPoint(30, 16),
			new DataPoint(40, 12),
			new DataPoint(50, 12)
			};
			var m = new PlotModel ("Titleee");
			m.PlotType = PlotType.XY;
			var s = new LineSeries ();
			s.ItemsSource = Points;
			m.Series.Add (s);
			//var opv = new OxyPlotView 
			//{
			//WidthRequest = 300, HeightRequest = 300,
			//BackgroundColor = Color.Aqua
			//};
			//opv.Model = m;

        	MainPage = 
				new ContentPage
				{
					Content = new PlotView
					{
						Model = new global::OxyPlot.PlotModel 
						{ 
							Title = "Hello Xamarin.Forms" 
						},
						VerticalOptions = LayoutOptions.Fill,
						HorizontalOptions = LayoutOptions.Fill,
					},
				};

			return;
		}

		/*
		public static Page GetMainPage()
		{
			return 
				new ContentPage
				{
					Content = new OxyPlot.XamarinForms.PlotView
					{
						Model = new OxyPlot.PlotModel { Title = "Hello Xamarin.Forms" },
						VerticalOptions = LayoutOptions.Fill,
						HorizontalOptions = LayoutOptions.Fill,
					},
				};
		}
		*/



	}
}
